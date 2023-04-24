using Billetes;
using IngresoDatos;

namespace POO_Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int opcion;
            int salida;*/
            Dolar dolares = new Dolar(20);
            Euro euro = new Euro(20);
            Peso peso = new Peso(20);
            Dolar auxiliar = new Dolar(20);

            /*peso = (Peso)dolares;

            Console.WriteLine(peso.Cantidad);
            auxiliar = dolares + peso;
            Console.WriteLine(auxiliar.Cantidad);*/

            auxiliar = (Dolar)euro;
            Console.WriteLine(auxiliar.Cantidad);





            /* do
             {
                 opcion = IngresoDatos.IngresoDatos.IngresarNumeroRango("DIVISAS DISPONIBLES PARA OPERAR\n" +
                 "1-Dolar - Peso\n" +
                 "2-Dolar - Euro\n" +
                 "3-Euro - Peso\n" +
                 "4-Euro - Dolar\n" +
                 "5-Peso - Dolar\n" +
                 "6-Peso - Euro\n", 1, 6);
                 switch (opcion)
                 {
                     case 1:

                     break;
                     case 2:
                     break;
                     case 3:
                     break;

                 }




             }while((salida = IngresoDatos.IngresoDatos.IngresarNumeroRango("\nPara continuar operando presione 0.\n Para salir 1.\n", 0, 1)) == 0);
             Console.WriteLine("<<<<<<<<<< FIN DEL PROGRAMA >>>>>>>>>>\n\n");*/




        }
    }
}