using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2SPA.Models.Repository
{
    public interface IChildRepository
    {
        IEnumerable<Child> GetAll();
        IEnumerable<Child> GetAllByHouseId(int id);
        Child Get(int id);
        Child Add(Child item);
        bool Update(Child item);
        bool Delete(int id);
    }
}
