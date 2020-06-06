using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSOPORTE.Cache
{
    public class UserLoginCache
    {

        public static int IDUsuario { get; set; }
        public static string Identificacion { get; set; }
        public static string Nombre { get; set; }
        public static string Clave { get; set; }
        public static string ClaveMovil { get; set; }
        public static DateTime FechaModificacionClave { get; set; }
        public static string Correo { get; set; }
        public static DateTime FechaUltimoLogin { get; set; }
        public static DateTime FechaActivacionInicial { get; set; }
        public static DateTime FechaActivacionFinal { get; set; }
        public static int NumerosDiasCambioClave { get; set; }
        public static int CambiarClaveAlIngresar { get; set; }
        public static int LongitudMinima { get; set; }
        public static int DiasVencimientoClave { get; set; }
        public static int Activo { get; set; }
        public static string Notas { get; set; }

    }
}
