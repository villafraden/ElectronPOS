using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Contracts
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(int idPK);
       
        IEnumerable<Entity> GetAll();


    }
}
