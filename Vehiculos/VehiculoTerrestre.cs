using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        public short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }
        public Colores Color { get => color; set => color = value; }

        private string imprimirVehiculo() 
        {
            StringBuilder sb = new StringBuilder();
            // pongo a la propiedad, el atributo es private
            sb.AppendLine("Cantidad de ruedas " + CantidadRuedas);
            sb.AppendLine("Cantidad de puertas "+ CantidadPuertas);
            sb.AppendLine("Color " + Color);
            return sb.ToString();   
        }
        public override string ToString()
        {
            return this.imprimirVehiculo();
        }
    }
}
