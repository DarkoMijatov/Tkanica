using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tkanica.Helpers;
using Tkanica.Classes;

namespace Tkanica
{
    public partial class BalancesViewForm : Form
    {
        private string userName;
        public BalancesViewForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void BalancesViewForm_Load(object sender, EventArgs e)
        {
            List<Balance> balances = TransactionsHelper.GetBalances();
            Balance bank = balances.Where(b => b.Name == BalanceName.Bank).First();
            Balance wallet = balances.Where(b => b.Name == BalanceName.Wallet).First();
            labelBankAmount.Text = bank.Amount.ToString("0.00") + " din.";
            labelWalletAmount.Text = wallet.Amount.ToString("0.00") + " din.";
            labelTotalAmount.Text = (bank.Amount + wallet.Amount).ToString("0.00") + " din.";
        }

        private void buttonIncoming_Click(object sender, EventArgs e)
        {
            IncomingTransactionsForm incomingTransactions = new IncomingTransactionsForm(userName);
            incomingTransactions.ShowDialog();
            this.Refresh();
        }

        private void buttonOutgoing_Click(object sender, EventArgs e)
        {
            OutgoingTransactionsForm outgoingTransactions = new OutgoingTransactionsForm(userName);
            outgoingTransactions.ShowDialog();
            this.Refresh();
        }
    }
}
