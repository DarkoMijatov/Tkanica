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
    public partial class OutgoingTransactionsForm : Form
    {
        private string userName;
        public OutgoingTransactionsForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void comboBoxTransactionType_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBoxTransactionType.Text=="Izaberite namenu")
            {
                MessageBox.Show("Morate izabrati namenu!", "Greška");
                comboBoxTransactionType.Focus();
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaction = new Transaction();
                transaction.Kind = TransactionKind.Outgoing;
                transaction.Debtor = "";
                transaction.Creditor = textBoxCreditor.Text.Trim();
                transaction.BankTransaction = checkBoxBankTransaction.Checked;
                transaction.Amount = Convert.ToDouble(textBoxAmount.Text.Trim());
                transaction.Description = comboBoxTransactionType.Text + ": " + textBoxDescription.Text.Trim();
                Balance balance = transaction.BankTransaction ? TransactionsHelper.GetBalances().Where(b => b.Name == BalanceName.Bank).First() : TransactionsHelper.GetBalances().Where(b => b.Name == BalanceName.Wallet).First();
                if (transaction.Amount > balance.Amount)
                {
                    MessageBox.Show("Nemate dovoljno sredstava za ovu isplatu!", "Greška");
                    textBoxAmount.Clear();
                    textBoxAmount.Focus();
                }
                else
                {
                    TransactionsHelper.PostTransaction(transaction);
                    LogHelper.PostLog(userName, "Izvršena isplata: " + transaction.Creditor + " " + transaction.Description + " " + transaction.Amount.ToString("0.00"));
                    MessageBox.Show("Uspešno izvršena isplata:\nPrimalac uplate: " + transaction.Creditor + "\nOpis: " + transaction.Description + "\nIznos: " + transaction.Amount.ToString("0.00"), "Uspeh");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Iznos isplate je pogrešno unet!", "Greška");
                textBoxAmount.Clear();
                textBoxAmount.Focus();
            }
        }

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                try
                {
                    Transaction transaction = new Transaction();
                    transaction.Kind = TransactionKind.Outgoing;
                    transaction.Debtor = "";
                    transaction.Creditor = textBoxCreditor.Text.Trim();
                    transaction.BankTransaction = checkBoxBankTransaction.Checked;
                    transaction.Amount = Convert.ToDouble(textBoxAmount.Text.Trim());
                    transaction.Description = comboBoxTransactionType.Text + ": " + textBoxDescription.Text.Trim();
                    TransactionsHelper.PostTransaction(transaction);
                    LogHelper.PostLog(userName, "Nova isplata: " + transaction.Creditor + " " + transaction.Description + " " + transaction.Amount.ToString("0.00"));
                    MessageBox.Show("Uspešno isplaćena transakcija:\nPrimalac uplate: " + transaction.Creditor + "\nOpis: " + transaction.Description + "\nIznos: " + transaction.Amount.ToString("0.00"), "Uspeh");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Iznos isplate je pogrešno unet!", "Greška");
                    textBoxAmount.Clear();
                    textBoxAmount.Focus();
                }
            }
        }
    }
}
