using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSOPORTE.Cache;

namespace CAD.Repositories
{
    public abstract class MasterRepository : Repository
    {
        protected List<SqlParameter> parameters;



        protected int ExecuteNonQuery(string transactSQL)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSQL;
                    command.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }
                    int result = command.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }


            }
        }
               



        protected DataTable ExecuteReaderQuery(string transactSQL)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSQL;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }


            }
        }


        protected DataTable ExecuteReaderQueryStoreProcedure(string transactSQL)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand(transactSQL))
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in parameters)
                    {
                        command.Parameters.Add(item);
                    }

                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }


            }





        }



        protected DataTable ExecuteQueryLogin(string transactSQL)
        {
            //  string Variable;
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = transactSQL;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();




                    using (var tabla = new DataTable())
                    {
                        if (reader.HasRows)


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


                        tabla.Load(reader);
                        reader.Dispose();
                        return tabla;
                    }




                }
            }

        }
    }






}
