using Billetes;
using IngresoDatos;

namespace POO_Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int salida;
            Dolar dolar = new Dolar(20);
          
            Euro euro = new Euro(20);
            Peso peso = new Peso(20);


            Console.WriteLine($"Cantidades por default:\nUSD {dolar.Cantidad}\nEuro {euro.Cantidad}\nPeso {peso.Cantidad}\n");

            do
             {
                 opcion = IngresoDatos.IngresoDatos.IngresarNumeroRango("CONVERSIONES DISPONIBLES PARA OPERAR\n" +
                 "1-Dolar a Peso\n" +
                 "2-Dolar a Euro\n" +
                 "3-Euro a Peso\n" +
                 "4-Euro a Dolar\n" +
                 "5-Peso a Dolar\n" +
                 "6-Peso a Euro\n", 1, 6);
                 switch (opcion)
                 {
                     case 1:
                        Peso pesoAuxiliar = (Peso)dolar;
                        Console.WriteLine($"{dolar.Cantidad} equivalen a {pesoAuxiliar.Cantidad.ToString("F2")}");
                     break;
                     case 2:
                        Euro euroAuxiliar = (Euro)dolar;
                        Console.WriteLine($"{dolar.Cantidad} equivalen a {euroAuxiliar.Cantidad.ToString("F2")}");
                    break;
                    case 3:
                        Peso pesoAuxiliarDos = (Peso)euro;
                        Console.WriteLine($"{euro.Cantidad} equivalen a {pesoAuxiliarDos.Cantidad.ToString("F2")}");
                    break;
                    case 4:
                        Dolar dolarAuxiliar= (Dolar)euro;
                        Console.WriteLine($"{euro.Cantidad} equivalen a {dolarAuxiliar.Cantidad.ToString("F2")}");
                    break;
                    case 5:
                        Dolar dolarAuxiliarDos = (Dolar)peso;
                        Console.WriteLine($"{peso.Cantidad} equivalen a {dolarAuxiliarDos.Cantidad.ToString("F2")}");
                    break;
                    case 6:
                        Euro euroAuxiliarDos= (Euro)peso;
                        Console.WriteLine($"{peso.Cantidad} equivalen a {euroAuxiliarDos.Cantidad.ToString("F2")}");
                    break;

                 }
             }while((salida = IngresoDatos.IngresoDatos.IngresarNumeroRango("\nPara continuar operando presione 0.\n Para salir 1.\n", 0, 1)) == 0);
             Console.WriteLine("<<<<<<<<<< FIN DEL PROGRAMA >>>>>>>>>>\n\n");
        }
    }
}