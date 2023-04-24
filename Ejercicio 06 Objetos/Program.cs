namespace Ejercicio_06_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroIngresado;
            int salida = 0;
            int opcion;
            Cuenta unaCuenta;//variable de tipo cuenta - guarda una direccion de memoria
            unaCuenta = new Cuenta(); // construyo el objeto y ya lo tengo en memoria dinamica - ya esta inicializado con valores

            do
            {
                numeroIngresado = 0;

                opcion =Cuenta.IngresarNumeroRango("MENU PRINCIPAL\n" +
                    "1-Ver informacion de cuenta\n" +
                    "2-Ingresar Saldo a cuenta\n" +
                    "3-Retirar saldo de cuenta",1,3);

                switch(opcion)
                {
                    case 1: unaCuenta.MostrarCuenta();
                    break;
                    case 2:
                        numeroIngresado = Cuenta.IngresarNumeroFloat("Ingrese saldo a transferir");
                        unaCuenta.ingresarMonto(numeroIngresado);
                    break;
                    case 3:
                        numeroIngresado = Cuenta.IngresarNumeroFloat("Ingrese saldo a retirar");
                        unaCuenta.retirarMonto(numeroIngresado);
                    break;
                }
            } while ((salida = Cuenta.IngresarNumeroRango("\nPara continuar operando presione 0.\n Para salir 1.\n", 0, 1)) == 0);
            Console.WriteLine("<<<<<<<<<< FIN DEL PROGRAMA >>>>>>>>>>\n\n");
        }
    }
}

// los constructores no retornan nada, y no hace falta ponerles void. Son un tipo especial