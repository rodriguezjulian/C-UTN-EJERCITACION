//RODRIGUEZ JULIAN MANUEL 2B - EJERCICIO 03
namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bandera = 0;
            int valorIngresado;
            do
            {
                Console.WriteLine("Ingrese entero numero mayor a 0");
                // valorIngresado = int.Parse(Console.ReadLine());
                //VERIFICO QUE SE INGRESO UN INT
                //if (valorIngresado.GetType() == typeof(int) && valorIngresado > 0)
                if ((int.TryParse(Console.ReadLine(), out valorIngresado) == true) && valorIngresado > 1)
                {
                    Console.WriteLine("Numero ingresado: {0}", valorIngresado);
                    bandera = 1;
                }
                else
                {
                    Console.WriteLine("ERROR, Reingresar numero.");
                }
            } while (bandera == 0);

            for (int i = 2; i <= valorIngresado; i++)
            {
                bool esPrimo = true;

                // Verificar si el número actual es primo
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                // Mostrar el número si es primo
                if (esPrimo)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}