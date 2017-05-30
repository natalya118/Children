using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2SPA.Models
{
    public class Child
    {
        public int ChildId { get; set; }
        public int HouseId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Letter { get; set; }

        public House House { get; set; }
    }
}
