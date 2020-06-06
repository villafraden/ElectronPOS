using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Entities
{
    public class Usuario
    {   


            public int IDUsuario { get; set; }         
            public string Identificacion { get; set; }
            public string Nombre { get; set; }
            public string Clave { get; set; }
            public string ClaveMovil { get; set; }
            public DateTime FechaModificacionClave { get; set; }       
            public string Correo { get; set; }            
            public DateTime FechaUltimoLogin { get; set; }
            public DateTime FechaActivacionInicial { get; set; }
            public DateTime FechaActivacionFinal { get; set; }
            public int NumerosDiasCambioClave { get; set; }
            public int CambiarClaveAlIngresar { get; set; }
            public int LongitudMinima { get; set; }
            public int DiasVencimientoClave { get; set; }
            public int Activo { get; set; }
            public string Notas { get; set; }


    }
}
