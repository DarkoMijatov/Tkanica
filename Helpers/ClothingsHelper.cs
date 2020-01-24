using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tkanica.Classes;

namespace Tkanica.Helpers
{
    class ClothingsHelper
    {
        public static List<Clothing> GetClothings()
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "select c.ID as ID,k.Kind as Kind,c.Region as Region,c.Gender as Gender,c.Age as Age,c.Size as Size,c.ReservationID as ReservationID from Clothings c" +
                " join ClothingKinds k on c.Kind=k.ID order by ID";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            List<Clothing> clothings = new List<Clothing>();
            using (SqlDataReader reader = command.ExecuteReader())
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
                    clothings.Add(clothing);
                }
            }
            Program.sqlConnection.Close();
            return clothings;
        }

        public static List<string> GetClothingKinds()
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "select Kind from ClothingKinds";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            List<string> clothingKinds = new List<string>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    clothingKinds.Add(reader["Kind"].ToString());
                }
            }
            Program.sqlConnection.Close();
            return clothingKinds;
        }

        public static void PostClothing(Clothing clothing)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "insert into Clothings(Kind,Region,Gender,Age,Size,ReservationID) values (";
            query += "(select ID from ClothingKinds where Kind='" + clothing.Kind + "'),";
            query += "'" + clothing.Region + "',";
            if (clothing.Gender == ClothingGender.Male) query += "1,";
            else query += "2,";
            if (clothing.Age == ClothingAge.Adult) query += "1,";
            else query += "2,";
            query += "'"+clothing.Size + "',";
            query += "0)";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static void EditClothing(Clothing clothing, int reservationId)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "update Clothings set ";
            query += "Kind=(select ID from ClothingKinds where Kind='" + clothing.Kind + "'),";
            query += "Region='" + clothing.Region + "',";
            if (clothing.Gender == ClothingGender.Male) query += "Gender=1,";
            else query += "Gender=2,";
            if (clothing.Age == ClothingAge.Adult) query += "Age=1,";
            else query += "Age=2,";
            query += "Size='" + clothing.Size + "',";
            if (clothing.Reserved) query += "ReservationID=" + reservationId.ToString();
            else query += "ReservationID=0";
            query += " where ID=" + clothing.Id.ToString();
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static void DeleteClothing(int clothingId)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "delete from Clothings where ID=" + clothingId.ToString();
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }
    }
}
