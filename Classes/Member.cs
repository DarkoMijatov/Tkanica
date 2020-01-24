using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkanica.Classes
{
    class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int YearsOfExperience { get; set; }
        public int MembershipMonths { get; set; }
        public string Status { get; set; }
        public DateTime DateOfEntry { get; set; }
        public string Group { get; set; }
        public MembershipFee MembershipFee { get; set; }
        public double DebtAmount { get; set; }
        public List<int> Reservations { get; set; }

        public int Age()
        {
            int difference = DateTime.Now.Year - this.DateOfBirth.Year;
            if (DateTime.Now.Month < this.DateOfBirth.Month || (DateTime.Now.Month == this.DateOfBirth.Month && DateTime.Now.Day < this.DateOfBirth.Day))
            {
                difference--;
            }
            return difference;
        }
        
        public bool CandidateForRevokingMembership()
        {
            if (this.DebtAmount >= 6 * this.MembershipFee.Amount) return true;
            else return false;
        }

    }
}
