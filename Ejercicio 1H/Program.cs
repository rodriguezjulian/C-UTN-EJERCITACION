using Vehiculos;
using Enumerado;
using System;

namespace Ejercicio_1H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre vehiculoUno = new VehiculoTerrestre(4, 2, Colores.Azul);
            Camion vehiculoDos = new Camion(4, 2, Colores.Blanco,6,5000);
            Automovil vehiculoTres = new Automovil(4, 2, Colores.Rojo, 6, 5000);
            Moto vehiculoCuatro = new Moto (4, 2, Colores.Rojo, 1000 );


            Console.WriteLine("VehiculoTerrestre\n" + vehiculoUno.ToString());
            Console.WriteLine("Camion\n" + vehiculoDos.ToString());
            Console.WriteLine("\nAutomovil\n" + vehiculoTres.ToString());
            Console.WriteLine("\nMoto\n"+ vehiculoCuatro.ToString());
        }
    }
}