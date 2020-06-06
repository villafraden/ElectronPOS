using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.Contracts;
using CAD.Entities;
using System.Data;
using System.Data.SqlClient;

namespace CAD.Repositories
{
    public class ClienteRepository : MasterRepository, IClientRepository
    {
        //Campos o atributos
        private string selectAll;
        private string insert;
        private string update;
        private string delete;
        private string ConsultaClienteID;

        //Propiedades
        // :::


        //Constructores

        public ClienteRepository()
        {
            // selectAll = "select IDCliente, IDTipoDocumento, Documento, NombreComercial, NombresContacto, Direccion, Telefono1, Telefono2, Movil, Correo, Notas, Aniversario, FechaRegistro, IDSexo, IDTipoPersona, IDCiudad, CupoCredito, Descuento, AutorizacionDatos, RutaAutorizaciondatos from Cliente";

           selectAll = "SELECT  dbo.Cliente.*, dbo.TipoDocumento.TipoDocumento, dbo.Sexo.Sexo, dbo.TipoPersona.TipoPersona, dbo.Ciudades.Ciudad, dbo.TipoRegimen.TipoRegimen, dbo.ActividadEconomica.ActividadEconomica, dbo.FormaPago.FormaPago, dbo.Calificacion.Calificacion FROM dbo.Cliente INNER JOIN dbo.ActividadEconomica ON dbo.Cliente.IDActividadEconomica = dbo.ActividadEconomica.IDActividadEconomica INNER JOIN dbo.Calificacion ON dbo.Cliente.IDCalificacion = dbo.Calificacion.IDCalificacion INNER JOIN  dbo.Ciudades ON dbo.Cliente.IDCiudad = dbo.Ciudades.IDCiudad INNER JOIN dbo.Departamentos ON dbo.Ciudades.IDDepartamento = dbo.Departamentos.IDDepartamento INNER JOIN dbo.FormaPago ON dbo.Cliente.IDFormaPago = dbo.FormaPago.IDFormaPago INNER JOIN dbo.Sexo ON dbo.Cliente.IDSexo = dbo.Sexo.IDSexo INNER JOIN dbo.TipoDocumento ON dbo.Cliente.IDTipoDocumento = dbo.TipoDocumento.IDTipoDocumento INNER JOIN dbo.TipoPersona ON dbo.Cliente.IDTipoPersona = dbo.TipoPersona.IDTipoPersona INNER JOIN  dbo.TipoRegimen ON dbo.Cliente.IDTipoRegimen = dbo.TipoRegimen.IDTipoRegimen";

            insert = "insert into Cliente  values(@IDTipoDocumento,@Documento,@NombreComercial,@NombresContacto,@Direccion,@Telefono1,@Telefono2,@Movil,@Correo,@Notas,@Aniversario,@FechaRegistro,@IDSexo,@IDTipoPersona,@IDCiudad,@CupoCredito,@Descuento,@AutorizacionDatos,@RutaAutorizaciondatos,@IDTipoRegimen)";
            update = "update Cliente set IDTipoDocumento=@IDTipoDocumento,Documento=@Documento,NombreComercial=@NombreComercial,NombresContacto=@NombresContacto,Direccion=@Direccion,Telefono1=@Telefono1,Telefono2=@Telefono2,Movil=@Movil,Correo=@Correo,Notas=@Notas,Aniversario=@Aniversario,FechaRegistro=@FechaRegistro,IDSexo=@IDSexo,IDTipoPersona=@IDTipoPersona,IDCiudad=@IDCiudad,CupoCredito=@CupoCredito,Descuento=@Descuento,AutorizacionDatos=@AutorizacionDatos,RutaAutorizaciondatos=@RutaAutorizaciondatos, IDTipoRegimen=@IDTipoRegimen where IDCliente=@IDCliente";
            delete = "delete from Cliente where IDCliente=@IDCliente";
        }

        // Metodos, Comportamientos


        public int Add(Cliente entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IDTipoDocumento", entity.IDTipoDocumento));
            parameters.Add(new SqlParameter("@Documento", entity.Documento));
            parameters.Add(new SqlParameter("@DigitoChequeo", entity.DigitoChequeo));
            parameters.Add(new SqlParameter("@NombreComercial", entity.NombreComercial));
            parameters.Add(new SqlParameter("@NombresContacto", entity.ContactoFacturacion));
            parameters.Add(new SqlParameter("@Direccion", entity.Direccion));
            parameters.Add(new SqlParameter("@Telefono1", entity.Telefono1));
            parameters.Add(new SqlParameter("@Telefono2", entity.Telefono2));
            parameters.Add(new SqlParameter("@Movil", entity.Movil));
            parameters.Add(new SqlParameter("@Correo", entity.Correo));
            parameters.Add(new SqlParameter("@Notas", entity.Notas));
            parameters.Add(new SqlParameter("@Aniversario", entity.Aniversario));
            parameters.Add(new SqlParameter("@FechaRegistro", entity.FechaRegistro));
            parameters.Add(new SqlParameter("@IDSexo", entity.IDSexo));
            parameters.Add(new SqlParameter("@IDTipoPersona", entity.IDTipoPersona));
            parameters.Add(new SqlParameter("@IDCiudad", entity.IDCiudad));
            parameters.Add(new SqlParameter("@CupoCredito", entity.CupoCredito));
            parameters.Add(new SqlParameter("@Descuento", entity.PorcentajeDescuento));
            parameters.Add(new SqlParameter("@AutorizacionDatos", entity.AutorizacionDatos));
            parameters.Add(new SqlParameter("@RutaAutorizaciondatos", entity.RutaAutorizaciondatos));
            parameters.Add(new SqlParameter("@IDTipoRegimen", entity.IDTipoRegimen));
            parameters.Add(new SqlParameter("@IDFormaPago", entity.IDFormaPago));
            


            return ExecuteNonQuery(insert);


        }



        public int Edit(Cliente entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IDCliente", entity.IDCliente));
            parameters.Add(new SqlParameter("@IDTipoDocumento", entity.IDTipoDocumento));
            parameters.Add(new SqlParameter("@Documento", entity.Documento));
            parameters.Add(new SqlParameter("@DigitoChequeo", entity.DigitoChequeo));
            parameters.Add(new SqlParameter("@NombreComercial", entity.NombreComercial));
            parameters.Add(new SqlParameter("@NombresContacto", entity.ContactoFacturacion));
            parameters.Add(new SqlParameter("@Direccion", entity.Direccion));
            parameters.Add(new SqlParameter("@Telefono1", entity.Telefono1));
            parameters.Add(new SqlParameter("@Telefono2", entity.Telefono2));
            parameters.Add(new SqlParameter("@Movil", entity.Movil));
            parameters.Add(new SqlParameter("@Correo", entity.Correo));
            parameters.Add(new SqlParameter("@Notas", entity.Notas));
            parameters.Add(new SqlParameter("@Aniversario", entity.Aniversario));
            parameters.Add(new SqlParameter("@FechaRegistro", entity.FechaRegistro));
            parameters.Add(new SqlParameter("@IDSexo", entity.IDSexo));
            parameters.Add(new SqlParameter("@IDTipoPersona", entity.IDTipoPersona));
            parameters.Add(new SqlParameter("@IDCiudad", entity.IDCiudad));
            parameters.Add(new SqlParameter("@CupoCredito", entity.CupoCredito));
            parameters.Add(new SqlParameter("@Descuento", entity.PorcentajeDescuento));
            parameters.Add(new SqlParameter("@AutorizacionDatos", entity.AutorizacionDatos));
            parameters.Add(new SqlParameter("@RutaAutorizaciondatos", entity.RutaAutorizaciondatos));
            parameters.Add(new SqlParameter("@IDTipoRegimen", entity.IDTipoRegimen));
            parameters.Add(new SqlParameter("@IDFormaPago", entity.IDFormaPago));

            return ExecuteNonQuery(update);
        }


        public int Remove(int IDCliente)
        {

            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IDCliente", IDCliente));

            return ExecuteNonQuery(delete);

        }

        public IEnumerable<Cliente> GetAll() //Obtener todos los registros
        {
            var tableResult = ExecuteReaderQuery(selectAll);
            var listaClientes = new List<Cliente>();
            foreach (DataRow item in tableResult.Rows)
            {
                listaClientes.Add(new Cliente
                {
                    IDCliente = Convert.ToInt32(item[0]),
                    IDTipoDocumento = Convert.ToInt32(item[1]),
                    Documento = item[2].ToString(),
                    DigitoChequeo = item[3].ToString(),                    
                    NombreComercial = item[4].ToString(),                   
                    Direccion = item[5].ToString(),
                    Telefono1 = item[6].ToString(),
                    Telefono2 = item[7].ToString(),
                    Movil = item[8].ToString(),
                    Correo = item[9].ToString(),                  
                    Notas = item[10].ToString(),
                    Aniversario = Convert.ToDateTime(item[11]),
                    FechaRegistro = Convert.ToDateTime(item[12]),
                    IDSexo = Convert.ToInt32(item[13]),
                    IDTipoPersona = Convert.ToInt32(item[14]),
                    IDCiudad = Convert.ToInt32(item[15]),
                    IDTipoRegimen = Convert.ToInt32(item[16]),
                    IDActividadEconomica = Convert.ToInt32(item[17]),
                    Activo = Convert.ToInt32(item[18]),
                    CupoCredito = Convert.ToDouble(item[19]),
                    PorcentajeDescuento = (decimal)Convert.ToDouble(item[20]),
                    IDFormaPago = Convert.ToInt32(item[21]),
                    IDCalificacion = Convert.ToInt32(item[22]),
                    DiasOptimista = Convert.ToInt32(item[23]),
                    DiasPesimista = Convert.ToInt32(item[24]),
                    DiasGracia = Convert.ToInt32(item[25]),
                    ContactoFacturacion = item[26].ToString(),
                    CorreoFacturacion = item[27].ToString(),
                    AutorizacionDatos = (bool)item[28],
                    RutaAutorizaciondatos = item[29].ToString(),
                    TipoDocumento = item[30].ToString(), //Tipo Documento   
                    Sexo = item[31].ToString(),
                    TipoPersona = item[32].ToString(),
                    Ciudad = item[33].ToString(),                   
                    TipoRegimen = item[34].ToString(),
                    ActividadEconomica = item[35].ToString(),                
                    FormaPago = item[35].ToString(),
                    Calificacion = item[37].ToString()


                });
            }
            

            return listaClientes;
        }


        public IEnumerable<Cliente> ConsultaClienteXID(int IDCLIENTE) //Obtener todos los registros
        {

            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@IDCliente", IDCLIENTE));

            ConsultaClienteID = "ConsultaClienteByIDCliente";

            var tableResult = ExecuteReaderQueryStoreProcedure(ConsultaClienteID);
            var DatosCliente = new List<Cliente>();
            foreach (DataRow item in tableResult.Rows)
            {
                DatosCliente.Add(new Cliente
                {
                    IDCliente = Convert.ToInt32(item[0]),
                    IDTipoDocumento = Convert.ToInt32(item[1]),
                    Documento = item[2].ToString(),
                    DigitoChequeo = item[3].ToString(),
                    NombreComercial = item[4].ToString(),
                    ContactoFacturacion = item[5].ToString(),
                    Direccion = item[6].ToString(),
                    Telefono1 = item[7].ToString(),
                    Telefono2 = item[8].ToString(),
                    Movil = item[9].ToString(),
                    Correo = item[10].ToString(),
                    Notas = item[11].ToString(),
                    Aniversario = Convert.ToDateTime(item[12]),
                    FechaRegistro = Convert.ToDateTime(item[13]),
                    IDSexo = Convert.ToInt32(item[14]),
                    IDTipoPersona = Convert.ToInt32(item[15]),
                    IDCiudad = Convert.ToInt32(item[16]),
                    CupoCredito = Convert.ToDouble(item[17]),
                    PorcentajeDescuento = (decimal)Convert.ToDouble(item[18]),
                    AutorizacionDatos = (bool)item[19],
                    RutaAutorizaciondatos = item[20].ToString(),
                    IDTipoRegimen = Convert.ToInt32(item[21]),                    
                    IDFormaPago = Convert.ToInt32(item[22]),
                    IDDepartamento = Convert.ToInt32(item[23]),
                    //Sexo = item[23].ToString(),
                    //TipoDocumento = item[24].ToString(), //Tipo Documento
                    //TipoPersona = item[25].ToString(),
                    //TipoRegimen = item[26].ToString(),
                    //Ciudad = item[27].ToString(),
                    //FormaPago = item[28].ToString()
                });
            }


            return DatosCliente;
        }




        

       

        public IEnumerable<Cliente> ConsultaClienteDocumento(string documento)
        {

            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Documento", documento));

            ConsultaClienteID = "ConsultaClienteByDocumento";

            var tableResult = ExecuteReaderQueryStoreProcedure(ConsultaClienteID);
            var DatosCliente = new List<Cliente>();
            foreach (DataRow item in tableResult.Rows)
            {
                DatosCliente.Add(new Cliente
                {
                    IDCliente = Convert.ToInt32(item[0]),
                    IDTipoDocumento = Convert.ToInt32(item[1]),
                    Documento = item[2].ToString(),
                    DigitoChequeo = item[3].ToString(),
                    NombreComercial = item[4].ToString(),
                    ContactoFacturacion = item[5].ToString(),
                    Direccion = item[6].ToString(),
                    Telefono1 = item[7].ToString(),
                    Telefono2 = item[8].ToString(),
                    Movil = item[9].ToString(),
                    Correo = item[10].ToString(),
                    Notas = item[11].ToString(),
                    Aniversario = Convert.ToDateTime(item[12]),
                    FechaRegistro = Convert.ToDateTime(item[13]),
                    IDSexo = Convert.ToInt32(item[14]),
                    IDTipoPersona = Convert.ToInt32(item[15]),
                    IDCiudad = Convert.ToInt32(item[16]),
                    CupoCredito = Convert.ToDouble(item[17]),
                    PorcentajeDescuento = (decimal)Convert.ToDouble(item[18]),
                    AutorizacionDatos = (bool)item[19],
                    RutaAutorizaciondatos = item[20].ToString(),
                    IDTipoRegimen = Convert.ToInt32(item[21]),
                    IDFormaPago = Convert.ToInt32(item[22]),
                    IDDepartamento = Convert.ToInt32(item[23]),
                    //Sexo = item[21].ToString(),
                    //TipoDocumento = item[22].ToString(), //Tipo Documento
                    //TipoPersona = item[23].ToString(),
                    //TipoRegimen = item[24].ToString(),
                    //Ciudad = item[25].ToString()
                });
            }


            return DatosCliente;

        }
    }
}
