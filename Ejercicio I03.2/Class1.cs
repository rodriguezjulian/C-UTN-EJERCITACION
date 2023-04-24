using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03._2
{
    internal class Conversor
    {

        public static string ConvertirDecimalABinario(int numeroEntero) 
        {













            int auxiliar= numeroEntero;
            StringBuilder binario = new StringBuilder();
         
           do
            {      
                if (auxiliar % 2 == 0)
                {
                    binario.Append("0");
                }
                else
                {
                    binario.Append("1");
                }
                auxiliar = auxiliar / 2;

            } while (auxiliar!=1);
            
            char[] caracteres = binario.ToString().ToCharArray();
            Array.Reverse(caracteres);
            string binarioInvertido = new string(caracteres);
            // Console.Write(binario);
            return binarioInvertido;
        }
    }
}
