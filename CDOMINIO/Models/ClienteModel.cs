using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.Contracts;
using CAD.Entities;
using CAD.Repositories;
using CDOMINIO.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Windows.Forms;

namespace CDOMINIO.Models
{
    public class ClienteModel : IDisposable
    {

        //----------------------------------------------CLIENTES
        private int IDCliente;
        private int IDTipoDocumento;
        private string Documento;
        private string DigitoChequeo;
        private string NombreComercial;       
        private string Direccion;
        private string Telefono1;
        private string Telefono2;
        private string Movil;
        private string Correo;
        private string Notas;
        private DateTime Aniversario;
        private DateTime FechaRegistro;
        private int IDSexo;
        private int IDTipoPersona;
        private int IDCiudad;
        private int IDTipoRegimen;
        private int IDActividadEconomica;
        private int Activo;   
        private double CupoCredito;
        private decimal PorcentajeDescuento;
        private int IDFormaPago;
        private int IDCalificacion;
        private int DiasOptimista;
        private int DiasPesimista;
        private int DiasGracia;
        private string ContactoFacturacion;
        private string CorreoFacturacion;
        private bool AutorizacionDatos;
        private string RutaAutorizaciondatos;
        private int IDDepartamento;
        private string Sexo;
        private string FormaPago;
        private string TipoDocumento;
        private string TipoPersona;
        private string TipoRegimen;
        private string Ciudad;
        private string ActividadEconomica;
        private string Calificacion;
        private int Edad;

        private List<ClienteModel> listaClientes; 

        private IClientRepository clientRepository;
        public EntityStates State { private get; set; }

        // PROPIEDADES / MODELOS DE VISTA/ VALIDAR DATOS
        public int idCliente { get => IDCliente; set => IDCliente = value; }

      //  [Required(ErrorMessage = "El campo Tipo de Documento es Requerido")]
        public int idTipoDocumento { get => IDTipoDocumento; set => IDTipoDocumento = value; }

     //   [Required(ErrorMessage = "El campo Numero de Documento es Requerido")]
    //    [RegularExpression("([0-9]+)", ErrorMessage = "El Numero de Documento solo puede ser numerico")]
     //   [StringLength(maximumLength: 12, MinimumLength = 7, ErrorMessage = "El Numero de Documento debe ser minimo de 7 Caracteres y Maximo de 12")]
        public string documento { get => Documento; set => Documento = value; }

    //    [Required(ErrorMessage = "El campo Nombre es Requerido")]
    //    [StringLength(maximumLength: 200, MinimumLength = 3, ErrorMessage = "El Nombre debe ser minimo de 3 Caracteres y Maximo de 200")]
        public string nombreComercial { get => NombreComercial; set => NombreComercial = value; }

        public string contactoFacturacion { get => ContactoFacturacion; set => ContactoFacturacion = value; }
    //    [Required]
        public string direccion { get => Direccion; set => Direccion = value; }
    //    [Required]
        public string telefono1 { get => Telefono1; set => Telefono1 = value; }
        public string telefono2 { get => Telefono2; set => Telefono2 = value; }
    //    [Required]
        public string movil { get => Movil; set => Movil = value; }
     //   [Required]
    //    [EmailAddress]
        public string correo { get => Correo; set => Correo = value; }
        public string notas { get => Notas; set => Notas = value; }

        public DateTime aniversario { get => Aniversario; set => Aniversario = value; }
        public DateTime fechaRegistro { get => FechaRegistro; set => FechaRegistro = value; }
       // [Required]
        public int idSexo { get => IDSexo; set => IDSexo = value; }
       // [Required]
        public int idTipoPersona { get => IDTipoPersona; set => IDTipoPersona = value; }
       // [Required]
        public int idCiudad { get => IDCiudad; set => IDCiudad = value; }
       // [Required(ErrorMessage = "El campo cupo de credito es Requerido")]
       // [RegularExpression("([0-9]+)", ErrorMessage = "El campo cupo de credito solo puede ser numerico")]
        public double cupoCredito { get => CupoCredito; set => CupoCredito = value; }
      //  [Required(ErrorMessage = "El campo cupo de credito es Requerido")]
      //  [RegularExpression("([0-9]+)", ErrorMessage = "El campo de descuento solo puede ser numerico")]
        public decimal porcentajeDescuento { get => PorcentajeDescuento; set => PorcentajeDescuento = value; }
      //  [Required]
        public bool autorizacionDatos { get => AutorizacionDatos; set => AutorizacionDatos = value; }
        public string rutaAutorizaciondatos { get => RutaAutorizaciondatos; set => RutaAutorizaciondatos = value; }
        public int idTipoRegimen { get => IDTipoRegimen; set => IDTipoRegimen = value; }
        public string digitoChequeo { get => DigitoChequeo; set => DigitoChequeo = value; }
        public string sexo { get => Sexo; set => Sexo = value; }
        public string tipoDocumento { get => TipoDocumento; set => TipoDocumento = value; }
        public string tipoPersona { get => TipoPersona; set => TipoPersona = value; }        
        public string tipoRegimen { get => TipoRegimen; set => TipoRegimen = value; }
        public string actividadEconomica { get => ActividadEconomica; set => ActividadEconomica = value; }
        public string formaPago { get => FormaPago; set => FormaPago = value; }
        public int edad { get => Edad; set => Edad = value; }
        public int idDepartamento { get => IDDepartamento; set => IDDepartamento = value; }
        public int idFormaPago { get => IDFormaPago; set => IDFormaPago = value; }
        
        public int idActividadEconomica { get => IDActividadEconomica; set => IDActividadEconomica = value; }
        public int activo { get => Activo; set => Activo = value; }
        public int idCalificacion { get => IDCalificacion; set => IDCalificacion = value; }
        public int diasOptimista { get => DiasOptimista; set => DiasOptimista = value; }
        public int diasPesimista { get => DiasPesimista; set => DiasPesimista = value; }
        public int diasGracia { get => DiasGracia; set => DiasGracia = value; }
        public string correoFacturacion { get => CorreoFacturacion; set => CorreoFacturacion = value; }
        public string calificacion { get => Calificacion; set => Calificacion = value; }

        //CONSTRUCTOR
        public ClienteModel()
        {
            clientRepository = new ClienteRepository();

        }

        public string SaveChanges()
        {
            string message = null;

            try
            {

                var clienteDataModel = new Cliente();

                clienteDataModel.IDCliente = IDCliente;
                clienteDataModel.IDTipoDocumento = IDTipoDocumento;
                clienteDataModel.Documento = Documento;
                clienteDataModel.NombreComercial = NombreComercial;
                clienteDataModel.ContactoFacturacion = ContactoFacturacion;
                clienteDataModel.Direccion = Direccion;
                clienteDataModel.Telefono1 = Telefono1;
                clienteDataModel.Telefono2 = Telefono2;
                clienteDataModel.Movil = Movil;
                clienteDataModel.Correo = Correo;
                clienteDataModel.Notas = Notas;
                clienteDataModel.Aniversario = Aniversario;
                clienteDataModel.FechaRegistro = FechaRegistro;
                clienteDataModel.IDSexo = IDSexo;
                clienteDataModel.IDTipoPersona = IDTipoPersona;
                clienteDataModel.IDCiudad = IDCiudad;
                clienteDataModel.CupoCredito = CupoCredito;
                clienteDataModel.PorcentajeDescuento = PorcentajeDescuento;
                clienteDataModel.AutorizacionDatos = AutorizacionDatos;
                clienteDataModel.RutaAutorizaciondatos = RutaAutorizaciondatos;
                clienteDataModel.IDTipoRegimen = IDTipoRegimen;
                


                switch (State)
                {

                    case EntityStates.Added:
                        // Ejecuta reglas comerciales / calculos
                        clientRepository.Add(clienteDataModel);
                        message = "EL REGISTRO FUE AGREGADO CORRECTAMENTE";
                        break;

                    case EntityStates.Modified:
                        clientRepository.Edit(clienteDataModel);
                        message = "EL REGISTRO FUE MODIFICADO CORRECTAMENTE";
                        break;

                    case EntityStates.Deleted:
                        clientRepository.Remove(IDCliente);
                        message = "EL REGISTRO FUE BORRADO CORRECTAMENTE";
                       // DialogResult rta = MessageBox.Show("EL REGISTRO FUE BORRADO CORRECTAMENTE", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }




            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2601)
                    message = "Registro Duplicado";
                else {
                    // message = ex.ToString();
                   message = "ESTE REGISTRO NO PUEDE SER BORRADO, DEBIDO A QUE TIENE REGISTROS RELACIONADOS";
                   
                }
            }

            return message;
        }


        public List<ClienteModel> GetAll()
        {
            var clienteDataModel = clientRepository.GetAll();
            listaClientes = new List<ClienteModel>();
            foreach (Cliente item in clienteDataModel)
            {

                var aniversario = item.Aniversario;
                listaClientes.Add(new ClienteModel
                {
                    IDCliente = item.IDCliente,
                    IDTipoDocumento = item.IDTipoDocumento,
                    Documento = item.Documento,
                    DigitoChequeo = item.DigitoChequeo,
                    NombreComercial = item.NombreComercial,
                    ContactoFacturacion = item.ContactoFacturacion,
                    Direccion = item.Direccion,
                    Telefono1 = item.Telefono1,
                    Telefono2 = item.Telefono2,
                    Movil = item.Movil,
                    Correo = item.Correo,
                    Notas = item.Notas,
                    Aniversario = item.Aniversario,
                    FechaRegistro = item.FechaRegistro,
                    IDSexo = item.IDSexo,
                    IDTipoPersona = item.IDTipoPersona,
                    IDCiudad = item.IDCiudad,
                    IDTipoRegimen = item.IDTipoRegimen,
                    IDActividadEconomica = item.IDActividadEconomica,
                    Activo = item.Activo,
                    CupoCredito = item.CupoCredito,
                    PorcentajeDescuento = item.PorcentajeDescuento,
                    IDFormaPago = item.IDFormaPago,
                    IDCalificacion = item.IDCalificacion,
                    DiasOptimista = item.DiasOptimista,
                    DiasPesimista = item.DiasPesimista,
                    DiasGracia = item.DiasGracia,
                    CorreoFacturacion = item.CorreoFacturacion,
                    AutorizacionDatos = item.AutorizacionDatos,
                    RutaAutorizaciondatos = item.RutaAutorizaciondatos,
                    TipoDocumento = item.TipoDocumento,
                    Sexo = item.Sexo,
                    TipoPersona = item.TipoPersona,
                    Ciudad = item.Ciudad,                   
                    TipoRegimen = item.TipoRegimen,
                    ActividadEconomica = item.ActividadEconomica,
                    FormaPago = item.FormaPago,
                    Calificacion = item.Calificacion,
                    edad = CalculaEdad(aniversario),






                });

            }
            

            return listaClientes;
        }

        public IEnumerable<ClienteModel> FindbByID(string filter)
        {
            
        return listaClientes.FindAll(e => e.documento.Contains(filter) || e.NombreComercial.Contains(filter)); //listaClientes ES UNA VISTA TEMPORAL PARA NO CONSULTAR CONSTANTEMENTE A LA BD
        }



        public List<ClienteModel> ConsultaClienteXID(int idCLIENTE)
        {
            //var clienteDataModel = new Cliente();

            //clienteDataModel.IDCliente = idCLIENTE;

            //clientRepository.ConsultaClienteXID(clienteDataModel.IDCliente);

            var clienteDataModel = clientRepository.ConsultaClienteXID(idCLIENTE);

            listaClientes = new List<ClienteModel>();

            foreach (Cliente item in clienteDataModel)
            {

                var aniversario = item.Aniversario;
                listaClientes.Add(new ClienteModel
                {
                    IDCliente = item.IDCliente,
                    IDTipoDocumento = item.IDTipoDocumento,
                    Documento = item.Documento,
                    NombreComercial = item.NombreComercial,
                    ContactoFacturacion = item.ContactoFacturacion,
                    Direccion = item.Direccion,
                    Telefono1 = item.Telefono1,
                    Telefono2 = item.Telefono2,
                    Movil = item.Movil,
                    Correo = item.Correo,
                    Notas = item.Notas,
                    Aniversario = item.Aniversario,
                    FechaRegistro = item.FechaRegistro,
                    IDSexo = item.IDSexo,
                    IDTipoPersona = item.IDTipoPersona,
                    IDCiudad = item.IDCiudad,
                    CupoCredito = item.CupoCredito,
                    PorcentajeDescuento = item.PorcentajeDescuento,
                    AutorizacionDatos = item.AutorizacionDatos,
                    RutaAutorizaciondatos = item.RutaAutorizaciondatos,
                    IDTipoRegimen = item.IDTipoRegimen,
                    IDDepartamento = item.IDDepartamento,
                    IDFormaPago = item.IDFormaPago,
                    //Sexo = item.Sexo,
                    //TipoDocumento = item.TipoDocumento,
                    //TipoPersona = item.TipoPersona,
                    //TipoRegimen = item.TipoRegimen,
                    //Ciudad = item.Ciudad,
                    edad = CalculaEdad(aniversario)

                });

            }


            return listaClientes;


        }

        public List<ClienteModel> ConsultaClienteXDocumento(string documento)
        {
            //var clienteDataModel = new Cliente();

            //clienteDataModel.IDCliente = idCLIENTE;

            //clientRepository.ConsultaClienteXID(clienteDataModel.IDCliente);

            var clienteDataModel = clientRepository.ConsultaClienteDocumento(documento);

            listaClientes = new List<ClienteModel>();

            foreach (Cliente item in clienteDataModel)
            {

                var aniversario = item.Aniversario;
                listaClientes.Add(new ClienteModel
                {
                    IDCliente = item.IDCliente,
                    IDTipoDocumento = item.IDTipoDocumento,
                    Documento = item.Documento,
                    NombreComercial = item.NombreComercial,
                    ContactoFacturacion = item.ContactoFacturacion,
                    Direccion = item.Direccion,
                    Telefono1 = item.Telefono1,
                    Telefono2 = item.Telefono2,
                    Movil = item.Movil,
                    Correo = item.Correo,
                    Notas = item.Notas,
                    Aniversario = item.Aniversario,
                    FechaRegistro = item.FechaRegistro,
                    IDSexo = item.IDSexo,
                    IDTipoPersona = item.IDTipoPersona,
                    IDCiudad = item.IDCiudad,
                    CupoCredito = item.CupoCredito,
                    PorcentajeDescuento = item.PorcentajeDescuento,
                    AutorizacionDatos = item.AutorizacionDatos,
                    RutaAutorizaciondatos = item.RutaAutorizaciondatos,
                    IDTipoRegimen = item.IDTipoRegimen,
                    IDDepartamento = item.IDDepartamento,
                    IDFormaPago = item.IDFormaPago,
                    //Sexo = item.Sexo,
                    //TipoDocumento = item.TipoDocumento,
                    //TipoPersona = item.TipoPersona,
                    //TipoRegimen = item.TipoRegimen,
                    //Ciudad = item.Ciudad,
                    edad = CalculaEdad(aniversario)

                });

            }


            return listaClientes;


        }



        private int CalculaEdad(DateTime date)
        {
            DateTime dateNow = DateTime.Now;

            return dateNow.Year - date.Year;

        }

        public void Dispose()
        {

        }
    }
}
