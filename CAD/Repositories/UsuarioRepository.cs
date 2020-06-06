using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.Entities;
using System.Data;
using System.Data.SqlClient;
using CAD.Contracts;
using CAD.Contracs;
using CSOPORTE.Cache;

namespace CAD.Repositories
{
    public class UsuarioRepository : MasterRepository, IUsuarioRepository
    {
        //Campos o atributos
        private string selectAll;
        private string insert;
        private string update;
        private string delete;


        //Propiedades
        // :::


        //Constructores

        public UsuarioRepository()
        {
            using (var command = new SqlCommand())


                // Login = "SELECT * FROM USUARIO WHERE Identificacion = @Identificacion AND Clave=@Clave";

           
            selectAll = "SELECT * FROM USUARIO";            
            insert = "INSERT INTO USARIO VALUES(@Identificacion,@Nombre,@Clave,@ClaveMovil,@FechaModificacion,@Correo,@FechaUltimoLogin,@FechaActivacionInicial,@FechaActivacionFinal,@NumerosDiasCambioClave,@CambiarClaveAlIngresar,@LongitudMinima,@DiasVencimientoClave,@Activo,@Notas)";
            update = "UPDATE USUARIO SET Identificacion=@Identificacion,Nombre=@Nombre,Clave=@Clave,ClaveMovil=@ClaveMovil,FechaModificacionClave=@FechaModificacionClave,Correo=@Correo,FechaUltimoLogin=@FechaUltimoLogin,FechaActivacionInicial=@FechaActivacionInicial,FechaActivacionFinal=@FechaActivacionFinal,NumerosDiasCambioClave=@NumerosDiasCambioClave,CambiarClaveAlIngresar=@CambiarClaveAlIngresar,LongitudMinima=@LongitudMinima,DiasVencimientoClave=@DiasVencimientoClave,Activo=@Activo,Notas=@Notas WHERE IDUsuario=@IDUsuario";
            delete = "DELETE FROM USUARIO WHERE IDUsuario=@IDUsuario";
        }

        // Metodos, Comportamientos


        public int Add(Usuario entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Identificacion", entity.Identificacion));
            parameters.Add(new SqlParameter("@Nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@Clave", entity.Clave));
            parameters.Add(new SqlParameter("@ClaveMovil", entity.ClaveMovil));
            parameters.Add(new SqlParameter("@FechaModificacionClave", entity.FechaModificacionClave));
            parameters.Add(new SqlParameter("@Correo", entity.Correo));
            parameters.Add(new SqlParameter("@FechaUltimoLogin", entity.FechaUltimoLogin));
            parameters.Add(new SqlParameter("@FechaActivacionInicial", entity.FechaActivacionInicial));
            parameters.Add(new SqlParameter("@FechaActivacionFinal", entity.FechaActivacionFinal));
            parameters.Add(new SqlParameter("@NumerosDiasCambioClave", entity.NumerosDiasCambioClave));
            parameters.Add(new SqlParameter("@CambiarClaveAlIngresar", entity.CambiarClaveAlIngresar));
            parameters.Add(new SqlParameter("@LongitudMinima", entity.LongitudMinima));
            parameters.Add(new SqlParameter("@DiasVencimientoClave", entity.DiasVencimientoClave));
            parameters.Add(new SqlParameter("@Activo", entity.Activo));
            parameters.Add(new SqlParameter("@Notas", entity.Notas));
            return ExecuteNonQuery(insert);


        }



        public int Edit(Usuario entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Identificacion", entity.Identificacion));
            parameters.Add(new SqlParameter("@Nombre", entity.Nombre));
            parameters.Add(new SqlParameter("@Clave", entity.Clave));
            parameters.Add(new SqlParameter("@ClaveMovil", entity.ClaveMovil));
            parameters.Add(new SqlParameter("@FechaModificacionClave", entity.FechaModificacionClave));
            parameters.Add(new SqlParameter("@Correo", entity.Correo));
            parameters.Add(new SqlParameter("@FechaUltimoLogin", entity.FechaUltimoLogin));
            parameters.Add(new SqlParameter("@FechaActivacionInicial", entity.FechaActivacionInicial));
            parameters.Add(new SqlParameter("@FechaActivacionFinal", entity.FechaActivacionFinal));
            parameters.Add(new SqlParameter("@NumerosDiasCambioClave", entity.NumerosDiasCambioClave));
            parameters.Add(new SqlParameter("@CambiarClaveAlIngresar", entity.CambiarClaveAlIngresar));
            parameters.Add(new SqlParameter("@LongitudMinima", entity.LongitudMinima));
            parameters.Add(new SqlParameter("@DiasVencimientoClave", entity.DiasVencimientoClave));
            parameters.Add(new SqlParameter("@Activo", entity.Activo));
            parameters.Add(new SqlParameter("@Notas", entity.Notas));
            return ExecuteNonQuery(update);
        }


        public IEnumerable<Usuario> GetAll() //Obtener todos los registros
        {
            var tableResult = ExecuteReaderQuery(selectAll);
            var listaUsuarios = new List<Usuario>();
            foreach (DataRow item in tableResult.Rows)
            {
                listaUsuarios.Add(new Usuario
                {
                    IDUsuario = Convert.ToInt32(item[0]),
                    Identificacion = item[1].ToString(),
                    Nombre = item[2].ToString(),
                    Clave = item[3].ToString(),
                    ClaveMovil = item[4].ToString(),
                    FechaModificacionClave = Convert.ToDateTime(item[5]),
                    Correo = item[6].ToString(),
                    FechaUltimoLogin = Convert.ToDateTime(item[7]),
                    FechaActivacionInicial = Convert.ToDateTime(item[8]),
                    FechaActivacionFinal = Convert.ToDateTime(item[9]),
                    NumerosDiasCambioClave = Convert.ToInt32(item[10]),
                    CambiarClaveAlIngresar = Convert.ToInt32(item[11]),
                    LongitudMinima = Convert.ToInt32(item[12]),
                    DiasVencimientoClave = Convert.ToInt32(item[13]),
                    Activo = Convert.ToInt32(item[14]),
                    Notas = item[15].ToString()                    


                });
            }

            return listaUsuarios;
        }


        public int Remove(int IDUsuario)
        {

            parameters = new List<SqlParameter>();
            parameters.Remove(new SqlParameter("@IDUsuario", IDUsuario));

            return ExecuteNonQuery(delete);

        }

        public bool LoginUser(string Identificacion, string Clave)
        {
            string transactSQL;

            // transactSQL = "SELECT * FROM USUARIO WHERE Identificacion =" + Identificacion + " AND Clave="+ Clave;

            transactSQL = "SELECT * FROM USUARIO WHERE Identificacion = @Identificacion AND Clave= @Clave";

            //  string Variable;
            using (var connection = GetSqlConnection())
            {


                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSQL;
                    command.Parameters.AddWithValue("@Identificacion", Identificacion);
                    command.Parameters.AddWithValue("@Clave", Clave);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            UserLoginCache.IDUsuario = reader.GetInt32(0);
                            UserLoginCache.Identificacion = reader.GetString(1);
                            UserLoginCache.Nombre = reader.GetString(2);
                            UserLoginCache.Clave = reader.GetString(3);
                            UserLoginCache.ClaveMovil = reader.GetString(4);
                            UserLoginCache.FechaModificacionClave = reader.GetDateTime(5);
                            UserLoginCache.Correo = reader.GetString(6);
                            UserLoginCache.FechaUltimoLogin = reader.GetDateTime(7);
                            UserLoginCache.FechaActivacionInicial = reader.GetDateTime(8);
                            UserLoginCache.FechaActivacionFinal = reader.GetDateTime(9);
                            UserLoginCache.NumerosDiasCambioClave = reader.GetInt32(10);
                            UserLoginCache.CambiarClaveAlIngresar = reader.GetInt32(11);
                            UserLoginCache.LongitudMinima = reader.GetInt32(12);
                            UserLoginCache.DiasVencimientoClave = reader.GetInt32(13);
                            UserLoginCache.Activo = reader.GetInt32(14);
                            UserLoginCache.Notas = reader.GetString(15);

                        }
                        return true;

                    }
                    else return false;
                }
            }

        }
      
        int IGenericRepository<Usuario>.Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        int IGenericRepository<Usuario>.Edit(Usuario entity)
        {
            throw new NotImplementedException();
        }

        int IGenericRepository<Usuario>.Remove(int idPK)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Usuario> IGenericRepository<Usuario>.GetAll()
        {
            throw new NotImplementedException();
        }

       
    }
}
