using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tkanica.Classes
{
    public enum ClothingGender
    {
        Male,
        Female
    }
    public enum ClothingAge
    {
        Adult,
        Child
    }
    class Clothing
    {
        public int Id { get; set; }
        public string Kind { get; set; }
        public string Region { get; set; }
        public ClothingGender Gender { get; set; }
        public ClothingAge Age { get; set; }
        public string Size { get; set; }
        public bool Reserved { get; set; }
    }
}
