//RODRIGUEZ JULIAN MANUEL 2B
//Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minimo = 0;
            int maximo = 0;
            int promedio = 0;
            int acumulador = 0;
            int valorIngresado = 0;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero: ");
                // Console.WriteLine("Valor i: {0}",i);
                valorIngresado = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    minimo = valorIngresado;
                    maximo = valorIngresado;
                }

                if (valorIngresado < minimo)
                {
                    minimo = valorIngresado;
                }
                else
                {
                    if (valorIngresado > maximo)
                    {
                        maximo = valorIngresado;
                    }
                }
                acumulador = acumulador + valorIngresado;
            }

            promedio = acumulador / i;
            Console.WriteLine($" El valor minimo ingresado es: {minimo}\n" +
                $"El valor maximo ingresado es: {maximo}\n" +
                $"Promedio: {promedio}");
        }
    }
}