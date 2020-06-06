using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CAD.Repositories
{
    public abstract class Repository
    {
        private readonly string connectionString;
        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ElectronPOS"].ToString();
        }

        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}

