using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkanica.Classes
{
    class Reservation
    {
        public int Id { get; set; }
        public Member Member { get; set; }
        public DateTime ReservationDate { get; set; }
        public List<Clothing> ReservedClothings { get; set; }
        public string Status { get; set; }
    }
}
