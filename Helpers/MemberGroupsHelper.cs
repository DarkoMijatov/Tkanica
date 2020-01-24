using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkanica.Classes;

namespace Tkanica.Helpers
{
    class MemberGroupsHelper
    {
        public static List<MemberGroup> GetMemberGroups()
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "select * from MemberGroups";
            List<MemberGroup> memberGroups = new List<MemberGroup>();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    MemberGroup memberGroup = new MemberGroup();
                    memberGroup.Id = Convert.ToInt32(reader["ID"].ToString());
                    memberGroup.Name = reader["Name"].ToString();
                    memberGroup.Count = Convert.ToInt32(reader["Count"].ToString());
                    memberGroups.Add(memberGroup);
                }
            }
            Program.sqlConnection.Close();
            return memberGroups;
        }

        public static void PostMemberGroup(string newMemberGroup)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "insert into MemberGroups(Name,Count) values ";
            sqlQuery += "('" + newMemberGroup + "',0)";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }
    }
}
