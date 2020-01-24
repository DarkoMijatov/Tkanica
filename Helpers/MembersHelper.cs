using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tkanica.Classes;

namespace Tkanica.Helpers
{
    class MembersHelper
    {
        public static List<Member> GetMembers()
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            List<Member> members = new List<Member>();
            List<int> feeIds = new List<int>();
            string sqlQuery = "select m.ID as ID,m.FirstName as FirstName,m.LastName as LastName,m.Address as Address,m.Location as Location,m.DateOfBirth as DateOfBirth,m.MobilePhone as MobilePhone,m.Email as Email," +
                "m.YearsOfExperience as YearsOfExperience,m.MembershipMonths as MembershipMonths,s.Status as Status,m.DateOfEntry as DateOfEntry,g.Name as MemberGroup,m.MembershipFeeID as MembershipFeeID,m.DebtAmount as DebtAmount,m.Reservations as Reservations " +
                "from Members m join MembershipStatuses s on m.Status=s.ID join MemberGroups g on m.MemberGroup=g.ID";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            using(SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Member member = new Member();
                    member.Id = Convert.ToInt32(reader["ID"]);
                    member.FirstName = reader["FirstName"].ToString();
                    member.LastName = reader["LastName"].ToString();
                    member.Address = reader["Address"].ToString();
                    member.Location = reader["Location"].ToString();
                    member.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                    member.MobilePhone = reader["MobilePhone"].ToString();
                    member.Email = reader["Email"].ToString();
                    member.YearsOfExperience = Convert.ToInt32(reader["YearsOfExperience"]);
                    member.MembershipMonths = Convert.ToInt32(reader["MembershipMonths"]);
                    member.Status = reader["Status"].ToString();
                    member.DateOfEntry = DateTime.Parse(reader["DateOfEntry"].ToString());
                    member.Group = reader["MemberGroup"].ToString();
                    feeIds.Add(Convert.ToInt32(reader["MembershipFeeID"]));
                    member.DebtAmount = Convert.ToDouble(reader["DebtAmount"]);
                    member.Reservations = new List<int>();
                    if (reader["Reservations"].ToString().Trim() != "")
                    {
                        string[] reservations = reader["Reservations"].ToString().Split(',');
                        int n = reservations.Length;
                        for (int i = 0; i < n; i++)
                        {
                            member.Reservations.Add(Convert.ToInt32(reservations[i]));
                        }
                    }
                    members.Add(member);
                }
            }
            Program.sqlConnection.Close();
            foreach(Member member in members)
            {
                member.MembershipFee = TransactionsHelper.GetMembershipFees().Where(fee => fee.Id == feeIds.First()).First();
                feeIds.Remove(feeIds.First());
            }
            return members;
        }

        public static void PostMember(Member member)
        {
            bool debtUpdated = TransactionsHelper.CheckIfDebtIsUpdated(DateTime.Now.Month, DateTime.Now.Year);
            member.DebtAmount = debtUpdated ? member.MembershipFee.Amount : 0.00;
            int memberGroupId = MemberGroupsHelper.GetMemberGroups().Where(groups => groups.Name == member.Group).First().Id;
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "insert into Members(FirstName,LastName,Address,Location,DateOfBirth,MobilePhone,Email," +
                "YearsOfExperience,MembershipMonths,Status,DateOfEntry,MemberGroup,MembershipFeeID,DebtAmount,Reservations) " +
                "values ('" + member.FirstName + "'," +
                "'" + member.LastName + "'," +
                "'" + member.Address + "'," +
                "'" + member.Location + "'," +
                "convert(datetime,'" + member.DateOfBirth.ToString() + "')," +
                "'" + member.MobilePhone + "'," +
                "'" + member.Email + "'," +
                member.YearsOfExperience.ToString() + ",0,1," +
                "convert(datetime,'" + member.DateOfEntry.ToString() + "')," +
                memberGroupId.ToString() + "," + member.MembershipFee.Id.ToString() + "," +
                member.DebtAmount.ToString("0.00") + ",'')";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static void EditMember(Member member)
        {
            int memberGroupId = MemberGroupsHelper.GetMemberGroups().Where(groups => groups.Name == member.Group).First().Id;
            int statusId = 1;
            if (member.Status == "neaktivan") statusId = 2;
            string reservations = "";
            foreach (int reservation in member.Reservations)
            {
                if (member.Reservations.Last().Equals(reservation)) reservations += reservation.ToString();
                else reservations += reservation.ToString() + ",";
            }
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "update Members set " +
                "FirstName='" + member.FirstName + "'," +
                "LastName='" + member.LastName + "'," +
                "Address='" + member.Address + "'," +
                "Location='" + member.Location + "'," +
                "DateOfBirth=convert(datetime,'" + member.DateOfBirth.ToString() + "')," +
                "MobilePhone='" + member.MobilePhone + "'," +
                "Email='" + member.Email + "'," +
                "YearsOfExperience=" + member.YearsOfExperience.ToString() + "," +
                "MembershipMonths=" + member.MembershipMonths.ToString() + "," +
                "Status=" + statusId.ToString() + "," +
                "DateOfEntry=convert(datetime,'" + member.DateOfEntry.ToString() + "')," +
                "MemberGroup=" + memberGroupId.ToString() + "," +
                "MembershipFeeID=" + member.MembershipFee.Id.ToString() + "," +
                "DebtAmount=" + member.DebtAmount.ToString() + "," +
                "Reservations='" + reservations + "' where ID=" + member.Id.ToString();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static void DeleteMember(int memberId)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "delete from Members where ID=" + memberId.ToString();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }
    }
}
