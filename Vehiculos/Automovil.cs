using Enumerado;

namespace Vehiculos
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, 
            int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadMarchas = cantidadMarchas;
            this.PesoCarga = pesoCarga;
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
        public int PesoCarga { get => pesoCarga; set => pesoCarga = value; }

        public override string ToString()
        {
            return base.ToString() + "Cantidad de marchas: " + CantidadMarchas + "\nPeso de carga: " + PesoCarga;
        }

    }
}