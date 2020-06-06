using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CDOMINIO.Services
{
   public class AdjuntarArchivo
    {

        public string nuevaRutaArchivo { get; set; }
        //public string textoEncriptado { get; set; }

        public string NuevaRutaArchivo
        {
            get { return nuevaRutaArchivo; }
            set { nuevaRutaArchivo = value; }
        }

        


        //-------------------------------------------------------------------------- ADJUNTAR Y GUARDAR ARCHIVO

        public static bool GuardarArchivo(string NuevaRutaArchivo, string NombreArchivo )
        {
            
            string Extension;
            string Ruta_Archivo;


            try
            {
                OpenFileDialog PadArchivo = new OpenFileDialog();


                if (PadArchivo.ShowDialog() == DialogResult.OK)
                {

                    Ruta_Archivo = PadArchivo.FileName ;

                    Extension = Path.GetExtension(Ruta_Archivo);
                    NuevaRutaArchivo = NuevaRutaArchivo + NombreArchivo + Extension;

                    byte[] file = null;
                    Stream myStream = PadArchivo.OpenFile();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        myStream.CopyTo(ms);
                        file = ms.ToArray();

                        File.WriteAllBytes(NuevaRutaArchivo, file);
                    }



                }

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
       
    }
}
