using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkanica.Classes
{
    class MembershipFee
    {
        public int Id { get; set; }
        public MemberGroup MemberGroup { get; set; }
        public bool Discount { get; set; }
        public double Amount { get; set; }
    }
}
