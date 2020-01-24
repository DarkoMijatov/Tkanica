using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkanica.Classes;

namespace Tkanica.Helpers
{
    class LogHelper
    {
        public static void PostLog(string userName, string activity)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "insert into Log values(";
            sqlQuery += "'" + userName + "',getdate(),";
            sqlQuery += "'" + activity + "')";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static List<Log> GetLogs()
        {
            List<Log> logs = new List<Log>();
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string sqlQuery = "select * from Log order by DateTime desc";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, Program.sqlConnection);
            using(SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Log log = new Log();
                    log.UserName = reader["UserName"].ToString();
                    log.DateTime = Convert.ToDateTime(reader["DateTime"]);
                    log.Activity = reader["Activity"].ToString();
                    logs.Add(log);
                }
            }
            Program.sqlConnection.Close();
            return logs;
        }
    }
}
