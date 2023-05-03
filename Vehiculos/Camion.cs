using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerado;

namespace Vehiculos
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;
        /*        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;*/
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short 
            cantidadMarchas, int pesoCarga) : base (cantidadRuedas, cantidadPuertas,color)
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
