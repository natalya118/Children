using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2SPA.Models
{
    public enum Category
    {
            Clothes, 
            Food,
            Medicine,
            Other
        }

    public enum Type
    {
        Urgently,
        Not_Urgently,
        Wanted
    }
    public class Need
    {
        
        public int NeedId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category? Category { get; set; }
        public Type? Type { get; set; }
        public int ChildId { get; set; }

        public Child Child { get; set; }
    }
}
