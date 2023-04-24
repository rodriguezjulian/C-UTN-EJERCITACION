namespace IngresoDatos
{
    public class IngresoDatos
    {
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
        public static int IngresarNumeroRango(string mensaje, int min, int max)
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
            } while (bandera == 0);
            return numeroIngresado;
        }
        public static float IngresarNumeroFloat(string mensaje)
        {
            float operacion;
            int bandera = 0;
            do
            {
                Console.WriteLine(mensaje);
                if ((float.TryParse(Console.ReadLine(), out operacion) == true))
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
    }
}