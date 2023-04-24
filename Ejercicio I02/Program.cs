namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorIngresado;

            int bandera = 0;

            do
            {
                Console.WriteLine("Ingrese entero numero mayor a 0");
                // valorIngresado = int.Parse(Console.ReadLine());
                //VERIFICO QUE SE INGRESO UN INT
                //if (valorIngresado.GetType() == typeof(int) && valorIngresado > 0)
                if ((int.TryParse(Console.ReadLine(), out valorIngresado) == true) && valorIngresado > 0)
                {
                    bandera = 1;
                }
                else
                {
                    Console.WriteLine("ERROR, Reingresar numero.");
                }


            } while (bandera == 0);
            Console.WriteLine("Numero ingresado: {0}", valorIngresado);
            Console.WriteLine("{0} al cuadrado es : {1}", valorIngresado, Math.Pow(valorIngresado, 2));
            Console.WriteLine("{0} al cubo es : {1}", valorIngresado, Math.Pow(valorIngresado, 3));
        }
    }
}