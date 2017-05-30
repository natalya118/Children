using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2SPA.Models
{
    public class House
    {
        public int HouseId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public ApplicationUser Director { get; set; }
        public ICollection<Child> children { get; set; }
    }
}
