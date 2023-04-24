using System.Drawing;

namespace Enumerado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Colores unColor = Colores.Verde;

            //Console.WriteLine(unColor.ToString());//ToString convierte a cadena un valor

            //RECORRER LA LISTA Y MOSTRAR STRING
            /*foreach(String unColor in Enum.GetNames(typeof(Colores)))//getname es estatico por que lo llamo desde la clase
            {
                Console.WriteLine(unColor);
            }
            foreach (Colores unColor in Enum.GetValues(typeof(Colores))) // obtengo por valor
            {
                Console.WriteLine(unColor);
            }*/
            Colores unColor = Colores.Rojo;
            //interpreta aunque existan diferencias entre mayusculas y minisculas
            String color = "rojo";
            unColor = (Colores)Enum.Parse(typeof(Colores), color, true);
            Console.WriteLine(unColor);

        }
    }
}