using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2SPA.Models.Repository
{
    public interface INeedRepository
    {
        IEnumerable<Need> GetAll();
        IEnumerable<Need> GetAllByChildId(int id);
        Need Get(int id);
        Need Add(Need item);
        bool Update(Need item);
        bool Delete(int id);
    }
}
