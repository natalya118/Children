using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2SPA.Models.Repository
{
    public interface IHouseRepository
    {
        IEnumerable<House> GetAll();
        House Get(int id);
        House Add(House item);
        bool Update(House item);
        bool Delete(int id);
    }
}
