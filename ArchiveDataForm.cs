using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tkanica.Classes;
using Tkanica.Helpers;

namespace Tkanica
{
    public partial class ArchiveDataForm : Form
    {
        private string userName;
        public ArchiveDataForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateTimePickerDateFrom.Value;
            DateTime dateTo = dateTimePickerDateTo.Value;
            dateTo = dateTo.AddDays(1);
            if (comboBoxData.Text == "Izaberite podatke")
            {
                MessageBox.Show("Morate izabrati podatke za arhiviranje!", "Greška");
                comboBoxData.Focus();
            }
            else if (comboBoxData.Text == "Rezervacije")
            {
                if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
                string query = "insert into Reservations_arch(ID,MemberID,ClothingIDs," +
                    "ReservationDate,Status,ArchiveDate) ";
                query += "select ID,MemberID,ClothingIDs,ReservationDate,Status,getdate() from Reservations ";
                query += "where ReservationDate between '" + dateFrom.ToString("MM/dd/yyyy") + "'";
                query += " and '" + dateTo.ToString("MM/dd/yyyy") + "' ";
                query += "delete from Reservations where ReservationDate between '" + dateFrom.ToString("MM/dd/yyyy") + "'";
                query += " and '" + dateTo.ToString("MM/dd/yyyy") + "'";
                SqlCommand command = new SqlCommand(query, Program.sqlConnection);
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da arihivrate rezerivacije u periodu od " +
                    dateTimePickerDateFrom.Value.ToString("dd.MM.yyyy.") + " do " +
                    dateTimePickerDateTo.Value.ToString("dd.MM.yyyy.") + "?", "Potvrda", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    LogHelper.PostLog(userName, "arhivirane rezervacije od " + dateTimePickerDateFrom.Value.ToString("dd.MM.yyyy.") + " do " +
                    dateTimePickerDateTo.Value.ToString("dd.MM.yyyy."));
                    MessageBox.Show("Rezervacije su uspešno arhivirane", "Uspeh");
                }
                Program.sqlConnection.Close();
            }
            else
            {
                if (Program.sqlConnection.State == ConnectionState.Closed) Program.sqlConnection.Open();
                string query = "insert into Transactions_arch(ID,Kind,Debtor," +
                    "Creditor,Amount,TransactionDate,IsBankTransaction,Description,ArchiveDate) ";
                query += "select ID,Kind,Debtor,Creditor,Amount,TransactionDate,IsBankTransaction,Description,getdate() from Transactions ";
                query += "where TransactionDate between '" + dateFrom.ToString("MM/dd/yyyy") + "'";
                query += " and '" + dateTo.ToString("MM/dd/yyyy") + "' ";
                query += "delete from Transactions where TransactionDate between '" + dateFrom.ToString("MM/dd/yyyy") + "'";
                query += " and '" + dateTo.ToString("MM/dd/yyyy") + "'";
                SqlCommand command = new SqlCommand(query, Program.sqlConnection);
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite da arihivrate transakcije u periodu od " +
                    dateTimePickerDateFrom.Value.ToString("dd.MM.yyyy.") + " do " +
                    dateTimePickerDateTo.Value.ToString("dd.MM.yyyy.") + "?", "Potvrda", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    LogHelper.PostLog(userName, "arhivirane transakcije od " + dateTimePickerDateFrom.Value.ToString("dd.MM.yyyy.") + " do " +
                    dateTimePickerDateTo.Value.ToString("dd.MM.yyyy."));
                    MessageBox.Show("Transakcije su uspešno arhivirane", "Uspeh");
                }
                Program.sqlConnection.Close();
            }
        }
    }
}
