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
    public partial class IncomingTransactionsForm : Form
    {
        private string userName;
        private bool debtorIsAMember;
        public IncomingTransactionsForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaction = new Transaction();
                if (debtorIsAMember) transaction.Debtor = comboBoxDebtor.Text.Substring(comboBoxDebtor.Text.IndexOf("]") + 1);
                else transaction.Debtor = textBoxDebtor.Text.Trim();
                transaction.Creditor = "";
                transaction.BankTransaction = checkBoxBankTransaction.Checked;
                transaction.Amount = Convert.ToDouble(textBoxAmount.Text);
                transaction.Kind = TransactionKind.Incoming;
                transaction.Description = comboBoxTransactionType.Text + ": " + textBoxDescription.Text.Trim();
                TransactionsHelper.PostTransaction(transaction);
                LogHelper.PostLog(userName, "Nova uplata: " + transaction.Debtor + " " + transaction.Description + " " + transaction.Amount.ToString());
                if (transaction.Description.Contains("članarina"))
                {
                    int id = Convert.ToInt32(comboBoxDebtor.Text.Substring(1, comboBoxDebtor.Text.IndexOf("]") - 1));
                    Member member = MembersHelper.GetMembers().Where(m => m.Id == id).First();
                    member.DebtAmount -= member.MembershipFee.Amount;
                    MembersHelper.EditMember(member);
                    LogHelper.PostLog(userName, "Smanjeno dugovanje za člana: " + member.FirstName + " " + member.LastName);
                }
                MessageBox.Show("Uspešno uplaćena transakcija:\nUplatilac: " + transaction.Debtor + "\nOpis: " + transaction.Description + "\nIznos: " + transaction.Amount.ToString(), "Uspeh");
            }
            catch(FormatException)
            {
                MessageBox.Show("Iznos uplate nije ispravan!", "Greška");
            }
        }

        private void IncomingTransactionsForm_Load(object sender, EventArgs e)
        {
            List<Member> members = MembersHelper.GetMembers().Where(m => m.Status == "aktivan").ToList();
            foreach(Member member in members)
            {
                comboBoxDebtor.Items.Add("[" + member.Id.ToString() + "] " + member.FirstName + " " + member.LastName);
            }
            comboBoxDebtor.Visible = false;
            textBoxDebtor.Visible = true;
        }

        private void comboBoxTransactionType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxTransactionType.Text == "Izaberite namenu")
            {
                MessageBox.Show("Morate izabrati namenu uplate!", "Greška");
                comboBoxTransactionType.Focus();
            }
            else if (comboBoxTransactionType.Text == "članarina" || comboBoxTransactionType.Text == "putni troškovi")
            {
                comboBoxDebtor.Visible = true;
                textBoxDebtor.Visible = false;
                debtorIsAMember = true;
            }
            else
            {
                comboBoxDebtor.Visible = false;
                textBoxDebtor.Visible = true;
                debtorIsAMember = false;
            }
        }

        private void comboBoxDebtor_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBoxDebtor.Visible && comboBoxDebtor.Text == "Izaberite uplatioca")
            {
                MessageBox.Show("Morate izabrati uplatioca!", "Greška");
                comboBoxDebtor.Focus();
            }
        }

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                try
                {
                    Transaction transaction = new Transaction();
                    if (debtorIsAMember) transaction.Debtor = comboBoxDebtor.Text.Substring(comboBoxDebtor.Text.IndexOf("]") + 1);
                    else transaction.Debtor = textBoxDebtor.Text.Trim();
                    transaction.Creditor = "";
                    transaction.BankTransaction = checkBoxBankTransaction.Checked;
                    transaction.Amount = Convert.ToDouble(textBoxAmount.Text);
                    transaction.Kind = TransactionKind.Incoming;
                    transaction.Description = comboBoxTransactionType.Text + ": " + textBoxDescription.Text.Trim();
                    TransactionsHelper.PostTransaction(transaction);
                    LogHelper.PostLog(userName, "Nova uplata: " + transaction.Debtor + " " + transaction.Description + " " + transaction.Amount.ToString("0.00"));
                    if (transaction.Description.Contains("članarina"))
                    {
                        int id = Convert.ToInt32(comboBoxDebtor.Text.Substring(1, comboBoxDebtor.Text.IndexOf("]") - 1));
                        Member member = MembersHelper.GetMembers().Where(m => m.Id == id).First();
                        member.DebtAmount -= member.MembershipFee.Amount;
                        MembersHelper.EditMember(member);
                        LogHelper.PostLog(userName, "Smanjeno dugovanje za člana: " + member.FirstName + " " + member.LastName);
                    }
                    MessageBox.Show("Uspešno uplaćena transakcija:\nUplatilac: " + transaction.Debtor + "\nOpis: " + transaction.Description + "\nIznos: " + transaction.Amount.ToString("0.00"), "Uspeh");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Iznos uplate nije ispravan!", "Greška");
                    textBoxAmount.Clear();
                    textBoxAmount.Focus();
                }
            }
        }
    }
}
