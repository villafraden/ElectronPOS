using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDOMINIO.Services
{
    public class Utilidades
    {


        public static string ValidarDigitoChequeo(string unNit)
        {
            string miTemp;
            int miContador;
            int miResiduo;
            int miChequeo;
            int[] miArregloPA = new int[15];
            miArregloPA[0] = 3;
            miArregloPA[1] = 7;
            miArregloPA[2] = 13;
            miArregloPA[3] = 17;
            miArregloPA[4] = 19;
            miArregloPA[5] = 23;
            miArregloPA[6] = 29;
            miArregloPA[7] = 37;
            miArregloPA[8] = 41;
            miArregloPA[9] = 43;
            miArregloPA[10] = 47;
            miArregloPA[11] = 53;
            miArregloPA[12] = 59;
            miArregloPA[13] = 67;
            miArregloPA[14] = 71;
            miChequeo = 0;
            miResiduo = 0;
            for (miContador = 0; miContador < unNit.Length; miContador++)
            {
                miTemp = unNit[(unNit.Length - 1) - miContador].ToString();
                miChequeo = miChequeo + (Convert.ToInt32(miTemp) * miArregloPA[miContador]);
            }
            miResiduo = miChequeo % 11;
            if (miResiduo > 1)
                return Convert.ToString(11 - miResiduo);
            return miResiduo.ToString();
        }




        public static bool SignoPesos(string cadena)
        {
            string SignoPesos = "$";
            bool Pesos = cadena.Contains(SignoPesos);

            if(Pesos == false)
            {
                return false;
            }
            
            return true;

        }


        public static bool SignoPorcentaje(string cadena)
        {
            string SignoPorcentaje = "%";
            bool Pesos = cadena.Contains(SignoPorcentaje);

            if (Pesos == false)
            {
                return false;
            }

            return true;

        }


        public void RecortaResultado(double RESULTADO)
        {
            String resultado = "";
            String resultadofinal = "";
            String caracter;

            String ResultadoFinal = "";

            int x = 0;
            int y = 0;
            int z = 0;

            resultado = Convert.ToString(RESULTADO);
            y = resultado.Length;

            for (int i = 0; i < y + 1; i++)
            {


                caracter = resultado.Substring(x, 1);

                if ((caracter != ",") && (caracter != "."))
                {


                    x = x + 1;
                    z = z + 1;

                    resultadofinal = resultado.Substring(0, z);




                }
                else
                {


                    ResultadoFinal = resultadofinal;
                    break;

                }

            }



        }
    }
}
