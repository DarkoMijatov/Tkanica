using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tkanica.Classes;
using Tkanica.Helpers;

namespace Tkanica
{
    public partial class ViewArchivedDataForm : Form
    {
        public ViewArchivedDataForm()
        {
            InitializeComponent();
        }

        private void comboBoxData_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBoxData.Text == "Izaberite podatke")
            {
                MessageBox.Show("Morate izabrati podatke!", "Greška");
                comboBoxData.Focus();
            }
            else if (comboBoxData.Text == "Rezervacije")
            {
                DateTime dateFrom = dateTimePickerDateFrom.Value;
                DateTime dateTo = dateTimePickerDateTo.Value;
                dateTo = dateTo.AddDays(1);
                if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
                string query = "select * from Reservations_arch where ReservationDate between ";
                query += "'" + dateFrom.ToString("MM/dd/yyyy") + "' and '" + dateTo.ToString("MM/dd/yyyy") + "'";
                SqlCommand command = new SqlCommand(query, Program.sqlConnection);
                List<Reservation> reservations = new List<Reservation>();
                List<string> resClothingIds = new List<string>();
                List<DateTime> archDates = new List<DateTime>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Reservation reservation = new Reservation();
                        reservation.Id = Convert.ToInt32(reader["ID"]);
                        reservation.ReservationDate = Convert.ToDateTime(reader["ReservationDate"]);
                        reservation.Status = Convert.ToInt32(reader["Status"]) == 1 ? "aktivna" : "obrisana";
                        reservation.Member = new Member();
                        reservation.Member.Id = Convert.ToInt32(reader["MemberID"]);
                        resClothingIds.Add(reader["ClothingIDs"].ToString());
                        archDates.Add(Convert.ToDateTime(reader["ArchiveDate"]));
                        reservations.Add(reservation);
                    }
                }
                Program.sqlConnection.Close();
                DataTable table = new DataTable();
                table.Columns.Add("Šifra");
                table.Columns.Add("Član");
                table.Columns.Add("Nošnja");
                table.Columns.Add("Datum i vreme");
                table.Columns.Add("Status");
                table.Columns.Add("Datum arhiviranja");
                foreach (Reservation reservation in reservations)
                {
                    reservation.Member = MembersHelper.GetMembers().Where(m => m.Id == reservation.Member.Id).First();
                    table.Rows.Add(reservation.Id.ToString(), reservation.Member.FirstName + " " + reservation.Member.LastName,
                        resClothingIds.First().ToString(), reservation.ReservationDate.ToString("dd.MM.yyyy. HH:mm:ss"),
                        reservation.Status, archDates.First().ToString("dd.MM.yyyy."));
                    resClothingIds.Remove(resClothingIds.First());
                    archDates.Remove(archDates.First());
                }
                dataGridViewData.DataSource = table;
                dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                DateTime dateFrom = dateTimePickerDateFrom.Value;
                DateTime dateTo = dateTimePickerDateTo.Value;
                dateTo = dateTo.AddDays(1);
                if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
                string query = "select * from Transactions_arch where TransactionDate between ";
                query += "'" + dateFrom.ToString("MM/dd/yyyy") + "' and '" + dateTo.ToString("MM/dd/yyyy") + "'";
                SqlCommand command = new SqlCommand(query, Program.sqlConnection);
                List<Transaction> transactions = new List<Transaction>();
                List<DateTime> archDates = new List<DateTime>();
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
                        archDates.Add(Convert.ToDateTime(reader["ArchiveDate"]));
                        transactions.Add(transaction);
                    }
                }
                Program.sqlConnection.Close();
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Vrsta");
                table.Columns.Add("Uplatilac");
                table.Columns.Add("Primalac");
                table.Columns.Add("Datum");
                table.Columns.Add("Iznos");
                table.Columns.Add("Bankovna transakcija");
                table.Columns.Add("Opis");
                table.Columns.Add("Datum arhiviranja");
                foreach (Transaction transaction in transactions)
                {
                    string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                    string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                    table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                        transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                        bankTransaction, transaction.Description, archDates.First().ToString("dd.MM.yyyy."));
                    archDates.Remove(archDates.First());
                }
                dataGridViewData.DataSource = table;
                dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void dateTimePickerDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxData.Text == "Izaberite podatke")
            {
                MessageBox.Show("Morate izabrati podatke!", "Greška");
                comboBoxData.Focus();
            }
            else if (comboBoxData.Text == "Rezervacije")
            {
                DateTime dateFrom = dateTimePickerDateFrom.Value;
                DateTime dateTo = dateTimePickerDateTo.Value;
                dateTo = dateTo.AddDays(1);
                if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
                string query = "select * from Reservations_arch where ReservationDate between ";
                query += "'" + dateFrom.ToString("MM/dd/yyyy") + "' and '" + dateTo.ToString("MM/dd/yyyy") + "'";
                SqlCommand command = new SqlCommand(query, Program.sqlConnection);
                List<Reservation> reservations = new List<Reservation>();
                List<string> resClothingIds = new List<string>();
                List<DateTime> archDates = new List<DateTime>();
                using (SqlDataReader reader = command.ExecuteReader())
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
                        archDates.Add(Convert.ToDateTime(reader["ArchiveDate"]));
                        reservations.Add(reservation);
                    }
                }
                Program.sqlConnection.Close();
                DataTable table = new DataTable();
                table.Columns.Add("Šifra");
                table.Columns.Add("Član");
                table.Columns.Add("Nošnja");
                table.Columns.Add("Datum i vreme");
                table.Columns.Add("Status");
                table.Columns.Add("Datum arhiviranja");
                foreach (Reservation reservation in reservations)
                {
                    reservation.Member = MembersHelper.GetMembers().Where(m => m.Id == reservation.Member.Id).First();
                    table.Rows.Add(reservation.Id.ToString(), reservation.Member.FirstName + " " + reservation.Member.LastName,
                        resClothingIds.First().ToString(), reservation.ReservationDate.ToString("dd.MM.yyyy. HH:mm:ss"),
                        reservation.Status, archDates.First().ToString("dd.MM.yyyy."));
                    resClothingIds.Remove(resClothingIds.First());
                    archDates.Remove(archDates.First());
                }
                dataGridViewData.DataSource = table;
                dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                DateTime dateFrom = dateTimePickerDateFrom.Value;
                DateTime dateTo = dateTimePickerDateTo.Value;
                dateTo = dateTo.AddDays(1);
                if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
                string query = "select * from Transactions_arch where TransactionDate between ";
                query += "'" + dateFrom.ToString("MM/dd/yyyy") + "' and '" + dateTo.ToString("MM/dd/yyyy") + "'";
                SqlCommand command = new SqlCommand(query, Program.sqlConnection);
                List<Transaction> transactions = new List<Transaction>();
                List<DateTime> archDates = new List<DateTime>();
                using (SqlDataReader reader = command.ExecuteReader())
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
                        archDates.Add(Convert.ToDateTime(reader["ArchiveDate"]));
                        transactions.Add(transaction);
                    }
                }
                Program.sqlConnection.Close();
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Vrsta");
                table.Columns.Add("Uplatilac");
                table.Columns.Add("Primalac");
                table.Columns.Add("Datum");
                table.Columns.Add("Iznos");
                table.Columns.Add("Bankovna transakcija");
                table.Columns.Add("Opis");
                table.Columns.Add("Datum arhiviranja");
                foreach (Transaction transaction in transactions)
                {
                    string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                    string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                    table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                        transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                        bankTransaction, transaction.Description, archDates.First().ToString("dd.MM.yyyy."));
                    archDates.Remove(archDates.First());
                }
                dataGridViewData.DataSource = table;
                dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void dateTimePickerDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxData.Text == "Izaberite podatke")
            {
                MessageBox.Show("Morate izabrati podatke!", "Greška");
                comboBoxData.Focus();
            }
            else if (comboBoxData.Text == "Rezervacije")
            {
                DateTime dateFrom = dateTimePickerDateFrom.Value;
                DateTime dateTo = dateTimePickerDateTo.Value;
                dateTo = dateTo.AddDays(1);
                if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
                string query = "select * from Reservations_arch where ReservationDate between ";
                query += "'" + dateFrom.ToString("MM/dd/yyyy") + "' and '" + dateTo.ToString("MM/dd/yyyy") + "'";
                SqlCommand command = new SqlCommand(query, Program.sqlConnection);
                List<Reservation> reservations = new List<Reservation>();
                List<string> resClothingIds = new List<string>();
                List<DateTime> archDates = new List<DateTime>();
                using (SqlDataReader reader = command.ExecuteReader())
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
                        archDates.Add(Convert.ToDateTime(reader["ArchiveDate"]));
                        reservations.Add(reservation);
                    }
                }
                Program.sqlConnection.Close();
                DataTable table = new DataTable();
                table.Columns.Add("Šifra");
                table.Columns.Add("Član");
                table.Columns.Add("Nošnja");
                table.Columns.Add("Datum i vreme");
                table.Columns.Add("Status");
                table.Columns.Add("Datum arhiviranja");
                foreach (Reservation reservation in reservations)
                {
                    reservation.Member = MembersHelper.GetMembers().Where(m => m.Id == reservation.Member.Id).First();
                    table.Rows.Add(reservation.Id.ToString(), reservation.Member.FirstName + " " + reservation.Member.LastName,
                        resClothingIds.First().ToString(), reservation.ReservationDate.ToString("dd.MM.yyyy. HH:mm:ss"),
                        reservation.Status, archDates.First().ToString("dd.MM.yyyy."));
                    resClothingIds.Remove(resClothingIds.First());
                    archDates.Remove(archDates.First());
                }
                dataGridViewData.DataSource = table;
                dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                DateTime dateFrom = dateTimePickerDateFrom.Value;
                DateTime dateTo = dateTimePickerDateTo.Value;
                dateTo = dateTo.AddDays(1);
                if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
                string query = "select * from Transactions_arch where TransactionDate between ";
                query += "'" + dateFrom.ToString("MM/dd/yyyy") + "' and '" + dateTo.ToString("MM/dd/yyyy") + "'";
                SqlCommand command = new SqlCommand(query, Program.sqlConnection);
                List<Transaction> transactions = new List<Transaction>();
                List<DateTime> archDates = new List<DateTime>();
                using (SqlDataReader reader = command.ExecuteReader())
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
                        archDates.Add(Convert.ToDateTime(reader["ArchiveDate"]));
                        transactions.Add(transaction);
                    }
                }
                Program.sqlConnection.Close();
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Vrsta");
                table.Columns.Add("Uplatilac");
                table.Columns.Add("Primalac");
                table.Columns.Add("Datum");
                table.Columns.Add("Iznos");
                table.Columns.Add("Bankovna transakcija");
                table.Columns.Add("Opis");
                table.Columns.Add("Datum arhiviranja");
                foreach (Transaction transaction in transactions)
                {
                    string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                    string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                    table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                        transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                        bankTransaction, transaction.Description, archDates.First().ToString("dd.MM.yyyy."));
                    archDates.Remove(archDates.First());
                }
                dataGridViewData.DataSource = table;
                dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }
    }
}
