using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tkanica.Classes;

namespace Tkanica.Helpers
{
    class TransactionsHelper
    {
        public static List<MembershipFee> GetMembershipFees()
        {
            List<MembershipFee> fees = new List<MembershipFee>();
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "select * from MembershipFees order by ID";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            List<int> groupIds = new List<int>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    MembershipFee fee = new MembershipFee();
                    fee.Id = Convert.ToInt32(reader["ID"]);
                    fee.Amount = Convert.ToDouble(reader["Amount"]);
                    if (Convert.ToInt32(reader["Discount"]) == 1)
                    {
                        fee.Discount = true;
                    }
                    else
                    {
                        fee.Discount = false;
                    }
                    groupIds.Add(Convert.ToInt32(reader["MemberGroupID"]));
                    fees.Add(fee);
                }
            }
            Program.sqlConnection.Close();
            foreach (MembershipFee fee in fees)
            {
                fee.MemberGroup = MemberGroupsHelper.GetMemberGroups().Where(group => group.Id == groupIds.First()).First();
                groupIds.Remove(groupIds.First());
            }
            return fees;
        }

        public static void PostMembershipFee(MembershipFee fee)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "insert into MembershipFees(MemberGroupID,Discount,Amount) values (";
            query += fee.MemberGroup.Id.ToString() + ",";
            if (fee.Discount) query += "1,";
            else query += "0,";
            query += fee.Amount.ToString() + ")";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();

        }

        public static void EditMembershipFee(MembershipFee fee)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "update MembershipFees set ";
            query += "MemberGroupID = " + fee.MemberGroup.Id.ToString() + ",";
            if (fee.Discount) query += " Discount = 1,";
            else query += " Discount = 0,";
            query += "Amount = " + fee.Amount.ToString();
            query += " where ID = " + fee.Id.ToString();
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static void DeleteMembershipFee(MembershipFee fee)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "delete from MembershipFees where ID = " + fee.Id.ToString();
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "select * from Transactions order by ID";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Transaction transaction = new Transaction();
                    transaction.Id = Convert.ToInt32(reader["ID"]);
                    transaction.Kind = Convert.ToInt32(reader["Kind"]) == 1 ? TransactionKind.Incoming : TransactionKind.Outgoing;
                    transaction.Debtor = reader["Debtor"].ToString();
                    transaction.Creditor = reader["Creditor"].ToString();
                    transaction.Amount = Convert.ToDouble(reader["Amount"]);
                    transaction.DateTime = Convert.ToDateTime(reader["TransactionDate"]);
                    transaction.BankTransaction = Convert.ToInt32(reader["IsBankTransaction"]) == 1 ? true : false;
                    transaction.Description = reader["Description"].ToString();
                    transactions.Add(transaction);
                }
            }
            Program.sqlConnection.Close();
            return transactions;
        }

        public static void PostTransaction(Transaction transaction)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "insert into Transactions(Kind,Debtor,Creditor,Amount,TransactionDate,IsBankTransaction,Description) values(";
            query += transaction.Kind == TransactionKind.Incoming ? "1," : "2,";
            query += "'" + transaction.Debtor + "',";
            query += "'" + transaction.Creditor + "',";
            query += transaction.Amount.ToString() + ",";
            query += "getdate(),";
            query += transaction.BankTransaction ? "1," : "0,";
            query += "'" + transaction.Description + "')";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }

        public static List<Balance> GetBalances()
        {
            List<Balance> balances = new List<Balance>();
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "select * from Balances";
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Balance balance = new Balance();
                    balance.Name = reader["BalanceName"].ToString().Equals("Banka") ? BalanceName.Bank : BalanceName.Wallet;
                    balance.Amount = Convert.ToDouble(reader["Amount"]);
                    balances.Add(balance);
                }
            }
            Program.sqlConnection.Close();
            return balances;
        }

        public static bool CheckIfDebtIsUpdated(int month, int year)
        {
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "select * from DebtUpdates where DebtYear = "+year.ToString() +
                " and DebtMonth = " + month.ToString();
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            using(SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows) return true;
                else return false;
            }
        }

        public static void IncreaseDebt(int month, int year)
        {
            List<Member> members = MembersHelper.GetMembers().Where(m => m.Status == "aktivan").ToList();
            foreach(Member member in members)
            {
                member.DebtAmount += member.MembershipFee.Amount;
                if (member.DebtAmount > member.MembershipFee.Amount * 2) member.Status = "neaktivan";
                if (member.DebtAmount > member.MembershipFee.Amount * 5) member.Status = "obrisan";
                MembersHelper.EditMember(member);
            }
            if (Program.sqlConnection.State == System.Data.ConnectionState.Closed) Program.sqlConnection.Open();
            string query = "insert into DebtUpdates(DebtYear,DebtMonth) values(" + year.ToString() + "," + month.ToString() + ")"; 
            SqlCommand command = new SqlCommand(query, Program.sqlConnection);
            command.ExecuteNonQuery();
            Program.sqlConnection.Close();
        }
    }
}

