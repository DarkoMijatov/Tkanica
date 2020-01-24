using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkanica.Classes
{
    public enum BalanceName
    {
        Bank,
        Wallet
    }
    class Balance
    {
        public BalanceName Name { get; set; }
        public double Amount { get; set; }
    }
}
