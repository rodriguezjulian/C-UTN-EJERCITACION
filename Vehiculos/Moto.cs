using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos 
{
    public class Moto : VehiculoTerrestre
    {        /*        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;*/
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada): 
            base(cantidadRuedas, cantidadPuertas, color)
        {
            this.Cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public override string ToString()
        {
            return base.ToString() + "\nCilindrada " + Cilindrada;
        }
    }
}
