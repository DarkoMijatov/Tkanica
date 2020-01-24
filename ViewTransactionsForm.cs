using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tkanica.Classes;
using Tkanica.Helpers;

namespace Tkanica
{
    public partial class ViewTransactionsForm : Form
    {
        private string userName;
        public ViewTransactionsForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void ViewTransactionsForm_Load(object sender, EventArgs e)
        {
            checkBoxBank.Checked = true;
            checkBoxWallet.Checked = true;
            checkBoxIncoming.Checked = true;
            checkBoxOutgoing.Checked = true;
            List<Transaction> transactions = TransactionsHelper.GetTransactions();
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Uplatilac");
            table.Columns.Add("Primalac");
            table.Columns.Add("Datum");
            table.Columns.Add("Iznos");
            table.Columns.Add("Bankovna transakcija");
            table.Columns.Add("Opis");
            foreach(Transaction transaction in transactions)
            {
                string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                    transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                    bankTransaction, transaction.Description);
            }
            dataGridViewTransactions.DataSource = table;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void textBoxDebtor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                string debtor = textBoxDebtor.Text.ToLower().Trim();
                string creditor = textBoxCreditor.Text.ToLower().Trim();
                string type = comboBoxTransactionType.Text;
                DateTime dateFrom = dateTimePickerDateFrom.Value;
                DateTime dateTo = dateTimePickerDateTo.Value;
                List<Transaction> transactions = TransactionsHelper.GetTransactions();
                if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
                if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
                if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
                transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
                if (!checkBoxIncoming.Checked)
                {
                    transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
                }
                if (!checkBoxOutgoing.Checked)
                {
                    transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
                }
                if (!checkBoxBank.Checked)
                {
                    transactions = transactions.Where(t => t.BankTransaction == false).ToList();
                }
                if (!checkBoxWallet.Checked)
                {
                    transactions = transactions.Where(t => t.BankTransaction == true).ToList();
                }
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Vrsta");
                table.Columns.Add("Uplatilac");
                table.Columns.Add("Primalac");
                table.Columns.Add("Datum");
                table.Columns.Add("Iznos");
                table.Columns.Add("Bankovna transakcija");
                table.Columns.Add("Opis");
                foreach (Transaction transaction in transactions)
                {
                    string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                    string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                    table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                        transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                        bankTransaction, transaction.Description);
                }
                dataGridViewTransactions.DataSource = table;
                dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void textBoxCreditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string debtor = textBoxDebtor.Text.ToLower().Trim();
                string creditor = textBoxCreditor.Text.ToLower().Trim();
                string type = comboBoxTransactionType.Text;
                DateTime dateFrom = dateTimePickerDateFrom.Value;
                DateTime dateTo = dateTimePickerDateTo.Value;
                List<Transaction> transactions = TransactionsHelper.GetTransactions();
                if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
                if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
                if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
                transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
                if (!checkBoxIncoming.Checked)
                {
                    transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
                }
                if (!checkBoxOutgoing.Checked)
                {
                    transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
                }
                if (!checkBoxBank.Checked)
                {
                    transactions = transactions.Where(t => t.BankTransaction == false).ToList();
                }
                if (!checkBoxWallet.Checked)
                {
                    transactions = transactions.Where(t => t.BankTransaction == true).ToList();
                }
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Vrsta");
                table.Columns.Add("Uplatilac");
                table.Columns.Add("Primalac");
                table.Columns.Add("Datum");
                table.Columns.Add("Iznos");
                table.Columns.Add("Bankovna transakcija");
                table.Columns.Add("Opis");
                foreach (Transaction transaction in transactions)
                {
                    string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                    string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                    table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                        transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                        bankTransaction, transaction.Description);
                }
                dataGridViewTransactions.DataSource = table;
                dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void comboBoxTransactionType_SelectedValueChanged(object sender, EventArgs e)
        {
            string debtor = textBoxDebtor.Text.ToLower().Trim();
            string creditor = textBoxCreditor.Text.ToLower().Trim();
            string type = comboBoxTransactionType.Text;
            DateTime dateFrom = dateTimePickerDateFrom.Value;
            DateTime dateTo = dateTimePickerDateTo.Value;
            List<Transaction> transactions = TransactionsHelper.GetTransactions();
            if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
            if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
            if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
            transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
            if (!checkBoxIncoming.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
            }
            if (!checkBoxOutgoing.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
            }
            if (!checkBoxBank.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == false).ToList();
            }
            if (!checkBoxWallet.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == true).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Uplatilac");
            table.Columns.Add("Primalac");
            table.Columns.Add("Datum");
            table.Columns.Add("Iznos");
            table.Columns.Add("Bankovna transakcija");
            table.Columns.Add("Opis");
            foreach (Transaction transaction in transactions)
            {
                string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                    transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                    bankTransaction, transaction.Description);
            }
            dataGridViewTransactions.DataSource = table;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dateTimePickerDateFrom_ValueChanged(object sender, EventArgs e)
        {
            string debtor = textBoxDebtor.Text.ToLower().Trim();
            string creditor = textBoxCreditor.Text.ToLower().Trim();
            string type = comboBoxTransactionType.Text;
            DateTime dateFrom = dateTimePickerDateFrom.Value;
            DateTime dateTo = dateTimePickerDateTo.Value;
            List<Transaction> transactions = TransactionsHelper.GetTransactions();
            if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
            if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
            if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
            transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
            if (!checkBoxIncoming.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
            }
            if (!checkBoxOutgoing.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
            }
            if (!checkBoxBank.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == false).ToList();
            }
            if (!checkBoxWallet.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == true).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Uplatilac");
            table.Columns.Add("Primalac");
            table.Columns.Add("Datum");
            table.Columns.Add("Iznos");
            table.Columns.Add("Bankovna transakcija");
            table.Columns.Add("Opis");
            foreach (Transaction transaction in transactions)
            {
                string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                    transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                    bankTransaction, transaction.Description);
            }
            dataGridViewTransactions.DataSource = table;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dateTimePickerDateTo_ValueChanged(object sender, EventArgs e)
        {
            string debtor = textBoxDebtor.Text.ToLower().Trim();
            string creditor = textBoxCreditor.Text.ToLower().Trim();
            string type = comboBoxTransactionType.Text;
            DateTime dateFrom = dateTimePickerDateFrom.Value;
            DateTime dateTo = dateTimePickerDateTo.Value;
            List<Transaction> transactions = TransactionsHelper.GetTransactions();
            if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
            if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
            if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
            transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
            if (!checkBoxIncoming.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
            }
            if (!checkBoxOutgoing.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
            }
            if (!checkBoxBank.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == false).ToList();
            }
            if (!checkBoxWallet.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == true).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Uplatilac");
            table.Columns.Add("Primalac");
            table.Columns.Add("Datum");
            table.Columns.Add("Iznos");
            table.Columns.Add("Bankovna transakcija");
            table.Columns.Add("Opis");
            foreach (Transaction transaction in transactions)
            {
                string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                    transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                    bankTransaction, transaction.Description);
            }
            dataGridViewTransactions.DataSource = table;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void checkBoxBank_CheckedChanged(object sender, EventArgs e)
        {
            string debtor = textBoxDebtor.Text.ToLower().Trim();
            string creditor = textBoxCreditor.Text.ToLower().Trim();
            string type = comboBoxTransactionType.Text;
            DateTime dateFrom = dateTimePickerDateFrom.Value;
            DateTime dateTo = dateTimePickerDateTo.Value;
            List<Transaction> transactions = TransactionsHelper.GetTransactions();
            if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
            if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
            if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
            transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
            if (!checkBoxIncoming.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
            }
            if (!checkBoxOutgoing.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
            }
            if (!checkBoxBank.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == false).ToList();
            }
            if (!checkBoxWallet.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == true).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Uplatilac");
            table.Columns.Add("Primalac");
            table.Columns.Add("Datum");
            table.Columns.Add("Iznos");
            table.Columns.Add("Bankovna transakcija");
            table.Columns.Add("Opis");
            foreach (Transaction transaction in transactions)
            {
                string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                    transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                    bankTransaction, transaction.Description);
            }
            dataGridViewTransactions.DataSource = table;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void checkBoxWallet_CheckedChanged(object sender, EventArgs e)
        {
            string debtor = textBoxDebtor.Text.ToLower().Trim();
            string creditor = textBoxCreditor.Text.ToLower().Trim();
            string type = comboBoxTransactionType.Text;
            DateTime dateFrom = dateTimePickerDateFrom.Value;
            DateTime dateTo = dateTimePickerDateTo.Value;
            List<Transaction> transactions = TransactionsHelper.GetTransactions();
            if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
            if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
            if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
            transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
            if (!checkBoxIncoming.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
            }
            if (!checkBoxOutgoing.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
            }
            if (!checkBoxBank.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == false).ToList();
            }
            if (!checkBoxWallet.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == true).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Uplatilac");
            table.Columns.Add("Primalac");
            table.Columns.Add("Datum");
            table.Columns.Add("Iznos");
            table.Columns.Add("Bankovna transakcija");
            table.Columns.Add("Opis");
            foreach (Transaction transaction in transactions)
            {
                string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                    transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                    bankTransaction, transaction.Description);
            }
            dataGridViewTransactions.DataSource = table;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void checkBoxIncoming_CheckedChanged(object sender, EventArgs e)
        {
            string debtor = textBoxDebtor.Text.ToLower().Trim();
            string creditor = textBoxCreditor.Text.ToLower().Trim();
            string type = comboBoxTransactionType.Text;
            DateTime dateFrom = dateTimePickerDateFrom.Value;
            DateTime dateTo = dateTimePickerDateTo.Value;
            List<Transaction> transactions = TransactionsHelper.GetTransactions();
            if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
            if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
            if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
            transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
            if (!checkBoxIncoming.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
            }
            if (!checkBoxOutgoing.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
            }
            if (!checkBoxBank.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == false).ToList();
            }
            if (!checkBoxWallet.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == true).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Uplatilac");
            table.Columns.Add("Primalac");
            table.Columns.Add("Datum");
            table.Columns.Add("Iznos");
            table.Columns.Add("Bankovna transakcija");
            table.Columns.Add("Opis");
            foreach (Transaction transaction in transactions)
            {
                string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                    transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                    bankTransaction, transaction.Description);
            }
            dataGridViewTransactions.DataSource = table;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void checkBoxOutgoing_CheckedChanged(object sender, EventArgs e)
        {
            string debtor = textBoxDebtor.Text.ToLower().Trim();
            string creditor = textBoxCreditor.Text.ToLower().Trim();
            string type = comboBoxTransactionType.Text;
            DateTime dateFrom = dateTimePickerDateFrom.Value;
            DateTime dateTo = dateTimePickerDateTo.Value;
            List<Transaction> transactions = TransactionsHelper.GetTransactions();
            if (debtor != "") transactions = transactions.Where(t => t.Debtor.ToLower().Contains(debtor)).ToList();
            if (creditor != "") transactions = transactions.Where(t => t.Creditor.ToLower().Contains(creditor)).ToList();
            if (type != "Izaberite namenu") transactions = transactions.Where(t => t.Description.Contains(type)).ToList();
            transactions = transactions.Where(t => t.DateTime <= dateTo && t.DateTime >= dateFrom).ToList();
            if (!checkBoxIncoming.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Incoming).ToList();
            }
            if (!checkBoxOutgoing.Checked)
            {
                transactions = transactions.Where(t => t.Kind != TransactionKind.Outgoing).ToList();
            }
            if (!checkBoxBank.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == false).ToList();
            }
            if (!checkBoxWallet.Checked)
            {
                transactions = transactions.Where(t => t.BankTransaction == true).ToList();
            }
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Vrsta");
            table.Columns.Add("Uplatilac");
            table.Columns.Add("Primalac");
            table.Columns.Add("Datum");
            table.Columns.Add("Iznos");
            table.Columns.Add("Bankovna transakcija");
            table.Columns.Add("Opis");
            foreach (Transaction transaction in transactions)
            {
                string kind = transaction.Kind == TransactionKind.Incoming ? "uplata" : "isplata";
                string bankTransaction = transaction.BankTransaction ? "da" : "ne";
                table.Rows.Add(transaction.Id.ToString(), kind, transaction.Debtor, transaction.Creditor,
                    transaction.DateTime.ToString("dd.MM.yyyy. HH:mm:ss"), transaction.Amount.ToString("0.00"),
                    bankTransaction, transaction.Description);
            }
            dataGridViewTransactions.DataSource = table;
            dataGridViewTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
