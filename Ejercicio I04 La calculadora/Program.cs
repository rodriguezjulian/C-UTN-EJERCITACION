//RODRIGUEZ JULIAN MANUEL 2B
namespace Ejercicio_I04_La_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            char referencia;
            int salida = 0;
            do
            {
                Console.WriteLine("<<<<<<<<<< CALCULADORA >>>>>>>>>>");
                numeroUno = Calculadora.IngresarNumero("Ingrese un numero.");
                numeroDos = Calculadora.IngresarNumero("Ingrese un numero.");

                /* referencia = Calculadora.IngresarNumeroRango*/  
                referencia= Calculadora.IngresarOperando("Ingrese segun desee operar: \n" +
                     "+ Sumar\n" +
                     "- Restar \n" +
                     "* Multiplicar \n" +
                     "/ Dividir \n"); 

                Console.WriteLine( "Resultado= {0}",Calculadora.Calcular(numeroUno, numeroDos, referencia));

            } while ((salida = Calculadora.IngresarNumeroRango("Para continuar operando presione 0.\n Para salir 1.\n",0,1)) == 0);
            Console.WriteLine("<<<<<<<<<< FIN DEL PROGRAMA >>>>>>>>>>\n\n");
        }
    }
}   