using CAD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Contracts
{
    public interface IClientRepository : IGenericRepository<Cliente>
    {
        //Others methods 
        //IEnumerable<Cliente> GetBySalary();

      
        IEnumerable<Cliente> ConsultaClienteXID(int idCLIENTE);
        IEnumerable<Cliente> ConsultaClienteDocumento(string documento);

    }
}
