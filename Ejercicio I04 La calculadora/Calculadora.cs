using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04_La_calculadora
{
    public class Calculadora
    {
        public static char IngresarOperando(string mensaje) 
        {
            char operando=' ';
            string? auxiliar;
            int bandera=0;
            do
            {
                Console.WriteLine(mensaje);
                auxiliar = Console.ReadLine();
                if (auxiliar?.Equals("+") == true || auxiliar?.Equals("-") == true || auxiliar?.Equals("*") == true || auxiliar?.Equals("/") == true)
                {
                    operando = char.Parse(auxiliar);
                    break;
                }
                Console.WriteLine("Error, recuerde ingresar + - * / ");
            } while (bandera == 0) ;

            return operando;
        }
        public static int IngresarNumero(string mensaje)
        {
            int operacion;
            int bandera = 0;
            do
            {
                Console.WriteLine(mensaje);
                if ((int.TryParse(Console.ReadLine(), out operacion) == true))
                {
                    bandera = 1;
                }
                else
                {
                    Console.WriteLine("ERROR, Ingresar numero.");
                }
            } while (bandera == 0);
            return operacion;
        }
        public static int IngresarNumeroRango(string mensaje, int min , int max) 
        {
            int numeroIngresado;
            int bandera = 0;
            do 
            {
                Console.WriteLine(mensaje);
                if ((int.TryParse(Console.ReadLine(), out numeroIngresado) == true) && numeroIngresado >= min && numeroIngresado <= max)
                {
                    bandera = 1;
                }
                else
                {
                    Console.WriteLine("ERROR, Reingresar numero.");
                }
            } while (bandera==0) ;
            return numeroIngresado;
        }
        private static bool Validar(int numeroDos) 
        {
            if (numeroDos!=0) 
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
        public static float Calcular(int numeroUno, int numeroDos, char referencia) 
        {
            float resultado=0;//me pide inicializar

            switch(referencia)
            {
                case '+':
                    resultado= numeroUno + numeroDos;
                break;
                case '-':
                    resultado= numeroUno - numeroDos;
                break;
                case '*':
                    resultado = numeroUno * numeroDos;
                break;
                case '/':
                    if (Validar(numeroDos) == true)
                    {
                        resultado = numeroUno / (float)numeroDos;
                    }
                    else
                    {
                        Console.WriteLine("Error, el segundo operando ingresado debe ser distinto a 0.");
                    }
                    
                break;
            }
            return resultado;
        }
    }
}
