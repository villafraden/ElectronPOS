using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD.Entities
{
    public class Cliente
    {
        //----------------------------------------------CLIENTES
        public int IDCliente { get; set; }
        public int IDTipoDocumento { get; set; }
        public string Documento { get; set; }
        public string DigitoChequeo { get; set; }
        public string NombreComercial { get; set; }       
        public string Direccion { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Movil { get; set; }
        public string Correo { get; set; }
        public string Notas { get; set; }
        public DateTime Aniversario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IDSexo { get; set; }
        public int IDTipoPersona { get; set; }
        public int IDCiudad { get; set; }     
        public int IDTipoRegimen { get; set; }
        public int IDActividadEconomica { get; set; }
        public int Activo { get; set; }        
        public double CupoCredito { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public int IDFormaPago { get; set; }
        public int IDCalificacion { get; set; }
        public int DiasOptimista { get; set; }
        public int DiasPesimista { get; set; }
        public int DiasGracia { get; set; }
        public string ContactoFacturacion { get; set; }
        public string CorreoFacturacion { get; set; }
        public bool AutorizacionDatos { get; set; }
        public string RutaAutorizaciondatos { get; set; }       
        public int IDDepartamento { get; set; }
        public string Sexo { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoPersona { get; set; }
        public string TipoRegimen { get; set; }
        public string Ciudad { get; set; }
        public string FormaPago { get; set; }
        public string ActividadEconomica { get; set; }
        public string Calificacion { get; set; }
        

    }
}
