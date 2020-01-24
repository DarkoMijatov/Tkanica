using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkanica.Classes;
using System.Data.SqlClient;

namespace Tkanica.Helpers
{
    class ReservationsHelper
    {
        public static List<Reservation> GetReservations()
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            List<Reservation> reservations = new List<Reservation>();
            string query = "select * from Reservations order by ID";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            List<string> resClothingIds = new List<string>();
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Reservation reservation = new Reservation();
                    reservation.Id = Convert.ToInt32(reader["ID"]);
                    reservation.ReservationDate = Convert.ToDateTime(reader["ReservationDate"]);
                    reservation.Status = Convert.ToInt32(reader["Status"]) == 1 ? "aktivna" : "obrisana";
                    reservation.Member = new Member();
                    reservation.Member.Id = Convert.ToInt32(reader["MemberID"]);
                    resClothingIds.Add(reader["ClothingIDs"].ToString());
                    reservations.Add(reservation);
                }
            }
            foreach(Reservation reservation in reservations)
            {
                reservation.Member = MembersHelper.GetMembers().Where(member => member.Id == reservation.Member.Id).First();
                reservation.ReservedClothings = new List<Clothing>();
                if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
                query = "select * from Clothings where ID in (" + resClothingIds.First() + ") order by ID";
                resClothingIds.Remove(resClothingIds.First());
                command = new SqlCommand(query, Program.sqlConnection);
                using(SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Clothing clothing = new Clothing();
                        clothing.Id = Convert.ToInt32(reader["ID"]);
                        clothing.Kind = reader["Kind"].ToString();
                        clothing.Region = reader["Region"].ToString();
                        if (Convert.ToInt32(reader["Gender"]) == 1) clothing.Gender = ClothingGender.Male;
                        else clothing.Gender = ClothingGender.Female;
                        if (Convert.ToInt32(reader["Age"]) == 1) clothing.Age = ClothingAge.Adult;
                        else clothing.Age = ClothingAge.Child;
                        clothing.Size = reader["Size"].ToString();
                        if (Convert.ToInt32(reader["ReservationID"]) == 0) clothing.Reserved = false;
                        else clothing.Reserved = true;
                        reservation.ReservedClothings.Add(clothing);
                    }
                }
            }
            Program.sqlConnection.Close();
            return reservations;
        }

        public static void PostReservation(Reservation reservation)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "insert into Reservations(MemberID,ClothingIDs,ReservationDate,Status) values (";
            List<int> ids = new List<int>();
            foreach (Clothing clothing in reservation.ReservedClothings)
            {
                ids.Add(clothing.Id);
            }
            string clothingIds = string.Join(",", ids);
            query += reservation.Member.Id.ToString() + ",'" + clothingIds + "',getdate(),1)";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static void DeleteReservation(Reservation reservation)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "update Reservations set Status = 0 where ID = " + reservation.Id.ToString();
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            reservation.Member.Reservations.Remove(reservation.Id);
            string reservationIds = "";
            foreach (int reservationId in reservation.Member.Reservations)
            {
                if (reservation.Member.Reservations.Last().Equals(reservationId)) reservationIds += reservationId.ToString();
                else reservationIds += reservationId.ToString() + ",";
            }
            query = "update Members set Reservations = '" + reservationIds + "' where ID = " + reservation.Member.Id.ToString();
            command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            foreach (Clothing clothing in reservation.ReservedClothings)
            {
                query = "update Clothings set ReservationID = 0 where ID = " + clothing.Id.ToString();
                command = new SqlCommand(query, Program.sqlConnection);
                command.ExecuteNonQuery();
            }
            Program.sqlConnection.Close();
        }
    }
}
