using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkanica.Classes;

namespace Tkanica.Helpers
{
    class UsersHelper
    {
        public static List<User> GetUsers()
        {
            if(Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "select * from Users";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            List<User> users = new List<User>();
            using(SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while(reader.Read())
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(reader["ID"].ToString());
                    user.UserName = reader["UserName"].ToString();
                    user.FirstName = reader["FirstName"].ToString();
                    user.LastName = reader["LastName"].ToString();
                    user.UserType = reader["UserType"].ToString();
                    user.DateCreated = Convert.ToDateTime(reader["DateCreated"].ToString());
                    users.Add(user);
                }
            }
            Program.sqlConnection.Close();
            return users;
        }

        public static void PostUser(User user)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "insert into Users(UserName,Password,FirstName,LastName,UserType,DateCreated) values(";
            sqlQuery += "'" + user.UserName + "',";
            sqlQuery += " HASHBYTES('SHA2_512', '" + user.Password + "'),";
            sqlQuery += "'" + user.FirstName + "',";
            sqlQuery += "'" + user.LastName + "',";
            sqlQuery += "'" + user.UserType + "',";
            sqlQuery += "getdate())";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static void ChangeUser(string userName, User changedUser)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "update Users set ";
            sqlQuery += "UserName = '" + changedUser.UserName + "',";
            sqlQuery += "FirstName = '" + changedUser.FirstName + "',";
            sqlQuery += "LastName = '" + changedUser.LastName + "',";
            sqlQuery += "UserType = '" + changedUser.UserType + "' ";
            sqlQuery += "where UserName='" + userName + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static void ChangePassword(string userName, string newPassword)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "update Users set Password=HASHBYTES('SHA2_512', '" + newPassword+"') where UserName='"+userName+"'";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static bool CheckUserCredentials(string userName, string password)
        {
            if (GetUsers().Where(users => users.UserName == userName).Any() == false) return false;
            else
            {
                if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
                string sqlQuery = "declare @pass binary(64) ";
                sqlQuery += "set @pass=(select Password from Users where UserName='" + userName + "') ";
                sqlQuery += "if (@pass = HASHBYTES('SHA2_512', '" + password + "')) select 'yes' as result ";
                sqlQuery += "else select 'no' as result";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    reader.Read();
                    string result = reader["result"].ToString();
                    if (result == "yes") return true;
                    else return false;
                }
            }
        }
    }
}
