using A2SPA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2SPA.Models.Repository
{
    public class ChildRepository : IChildRepository
    {
        private readonly A2spaContext _context;
        public Child Add(Child item)
        {
            _context.Child.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Child Get(int id)
        {
           return _context.Child.Find(id)p;
        }

        public IEnumerable<Child> GetAll()
        {
            return _context.Child;
        }

        public IEnumerable<Child> GetAllByHouseId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Child item)
        {
            throw new NotImplementedException();
        }
    }
}
