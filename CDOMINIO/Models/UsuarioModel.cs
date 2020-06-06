using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD.Entities;
using CAD.Repositories;
using CDOMINIO.ValueObjects;
using System.ComponentModel.DataAnnotations;
using CAD.Contracs;

namespace CDOMINIO.Models
{
    public class UsuarioModel : IDisposable
    {
        private int IDUsuario;
        private string Identificacion;
        private string Nombre;
        private string Clave;
        private string ClaveMovil;
        private DateTime FechaModificacionClave;
        private string Correo;    
        private DateTime FechaUltimoLogin;
        private DateTime FechaActivacionInicial;
        private DateTime FechaActivacionFinal;
        private int NumerosDiasCambioClave;
        private int CambiarClaveAlIngresar;
        private int LongitudMinima;
        private int DiasVencimientoClave;
        private int Activo;
        private string Notas;
        

        private List<UsuarioModel> listaUsuarios;



        private IUsuarioRepository usuarioRepository;
        public EntityStates State { private get; set; }

        // PROPIEDADES / MODELOS DE VISTA/ VALIDAR DATOS
        public int idUsuario { get => IDUsuario; set => IDUsuario = value; }

        [Required(ErrorMessage = "El campo Numero de Documento es Requerido")]
        [RegularExpression("([0-9]+)", ErrorMessage = "El Numero de Documento solo puede ser numerico")]
        [StringLength(maximumLength: 12, MinimumLength = 7, ErrorMessage = "El Numero de Documento debe ser minimo de 7 Caracteres y Maximo de 12")]
        public string identificacion { get => Identificacion; set => Identificacion = value; }
        [Required(ErrorMessage = "El campo Nombre es Requerido")]
        [StringLength(maximumLength: 200, MinimumLength = 3, ErrorMessage = "El Nombre debe ser minimo de 3 Caracteres y Maximo de 200")]
        public string nombre { get => Nombre; set => Nombre = value; }
        [Required]
        public string clave { get => Clave; set => Clave = value; }
        public string claveMovil { get => ClaveMovil; set => ClaveMovil = value; }
        [Required]
        public DateTime fechaModificacionClave { get => FechaModificacionClave; set => FechaModificacionClave = value; }
        [Required]
        [EmailAddress]
        public string correo { get => Correo; set => Correo = value; }
        public DateTime fechaUltimoLogin { get => FechaUltimoLogin; set => FechaUltimoLogin = value; }
        public DateTime fechaActivacionInicial { get => FechaActivacionInicial; set => FechaActivacionInicial = value; }
        public DateTime fechaActivacionFinal { get => FechaActivacionFinal; set => FechaActivacionFinal = value; }
        [Required]
        public int numerosDiasCambioClave { get => NumerosDiasCambioClave; set => NumerosDiasCambioClave = value; }
        [Required]
        public int cambiarClaveAlIngresar { get => CambiarClaveAlIngresar; set => CambiarClaveAlIngresar = value; }
        [Required]
        public int longitudMinima { get => LongitudMinima; set => LongitudMinima = value; }
        [Required]
        public int diasVencimientoClave { get => DiasVencimientoClave; set => DiasVencimientoClave = value; }
        [Required]
        public int activo { get => Activo; set => Activo = value; }
        public string notas { get => Notas; set => Notas = value; }



        //CONSTRUCTOR
        public UsuarioModel()
        {
            usuarioRepository = new UsuarioRepository();

        }

        public bool LoginUsuario(string usuario, string clave)
        {
            var usuarioDataModel = new Usuario();

            usuarioDataModel.Identificacion = usuario;
            usuarioDataModel.Clave = clave;

            usuarioRepository.LoginUser(usuarioDataModel.Identificacion, usuarioDataModel.Clave);

        
            return usuarioRepository.LoginUser(usuario, clave);

        }





        public string SaveChanges()
        {
            string message = null;

            try
            {

                var usuarioDataModel = new Usuario();

                usuarioDataModel.IDUsuario = IDUsuario;
                usuarioDataModel.Identificacion = Identificacion;
                usuarioDataModel.Nombre = Nombre;
                usuarioDataModel.Clave = Clave;
                usuarioDataModel.ClaveMovil = ClaveMovil;
                usuarioDataModel.FechaModificacionClave = FechaModificacionClave;
                usuarioDataModel.Correo = Correo;
                usuarioDataModel.FechaUltimoLogin = FechaUltimoLogin;
                usuarioDataModel.FechaActivacionInicial = FechaActivacionInicial;
                usuarioDataModel.FechaActivacionFinal = FechaActivacionFinal;
                usuarioDataModel.NumerosDiasCambioClave = NumerosDiasCambioClave;
                usuarioDataModel.CambiarClaveAlIngresar = CambiarClaveAlIngresar;
                usuarioDataModel.LongitudMinima = LongitudMinima;
                usuarioDataModel.DiasVencimientoClave = DiasVencimientoClave;
                usuarioDataModel.Activo = Activo;               
                usuarioDataModel.Notas = Notas;
                

                switch (State)
                {

                    case EntityStates.Added:
                        // Ejecuta reglas comerciales / calculos
                        usuarioRepository.Add(usuarioDataModel);
                        message = "El registro fue agregado correctamente";
                        break;

                    case EntityStates.Modified:
                        usuarioRepository.Edit(usuarioDataModel);
                        message = "El registro fue modificado correctamente";
                        break;

                    case EntityStates.Deleted:
                        usuarioRepository.Remove(IDUsuario);
                        message = "El registro fue borrado correctamente";
                        break;

                   



                }




            }
            catch (Exception ex)
            {
                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2601)
                    message = "Registro Duplicado";
                else
                    message = ex.ToString();

            }

            return message;
        }


        public List<UsuarioModel> GetAll()
        {
            var usuarioDataModel = usuarioRepository.GetAll();
            listaUsuarios = new List<UsuarioModel>();
            foreach (Usuario item in usuarioDataModel)
            {

              
                listaUsuarios.Add(new UsuarioModel
                {
                    IDUsuario = item.IDUsuario,
                    Identificacion = item.Identificacion,
                    Nombre = item.Nombre,
                    Clave = item.Clave,
                    ClaveMovil = item.ClaveMovil,
                    FechaModificacionClave = item.FechaModificacionClave,
                    Correo = item.Correo,
                    FechaUltimoLogin = item.FechaUltimoLogin,
                    FechaActivacionInicial = item.FechaActivacionInicial,
                    FechaActivacionFinal = item.FechaActivacionFinal,
                   
                    NumerosDiasCambioClave = item.NumerosDiasCambioClave,
                    CambiarClaveAlIngresar = item.CambiarClaveAlIngresar,
                    LongitudMinima = item.LongitudMinima,
                    DiasVencimientoClave = item.DiasVencimientoClave,
                    Activo = item.Activo,
                   Notas = item.Notas,

                });

            }

            return listaUsuarios;
        }

        public IEnumerable<UsuarioModel> FindbByID(string filter)
        {
            return listaUsuarios.FindAll(e => e.Identificacion.Contains(filter) || e.Nombre.Contains(filter)); //listaClientes ES UNA VISTA TEMPORAL PARA NO CONSULTAR CONSTANTEMENTE A LA BD
        }

       

        public void Dispose()
        {

        }

    }
}
