using CAD.Contracts;
using CAD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Contracs
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        //Others methods 
        //IEnumerable<Usuario> GetByRol();
        bool LoginUser(string identificacion, string clave);
    }
}
