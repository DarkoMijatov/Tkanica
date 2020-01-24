using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkanica.Classes
{
    public enum TransactionKind
    {
        Incoming,
        Outgoing
    }

    class Transaction
    {
        public int Id { get; set; }
        public TransactionKind Kind { get; set; }
        public string Debtor { get; set; }
        public string Creditor { get; set; }
        public DateTime DateTime { get; set; }
        public double Amount { get; set; }
        public bool BankTransaction { get; set; }
        public string Description { get; set; }
    }

}
