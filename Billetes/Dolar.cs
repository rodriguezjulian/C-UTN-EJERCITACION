using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        //VALOR STATIC, NO CAMBIA
        private static double cotizacionRespectoDolar;
        private double cantidad;
        // Constructores para la clase Dolar

        static Dolar()
        {
            Dolar.cotizacionRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        //SOBRE CARGO AL METODO
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizacionRespectoDolar = cotizacion;
        }

        public  double Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }
        public static double Cotizacion
        {
           get
            {
                //NO HAY TAL THIS PORQUE ES UN STATIC
                return cotizacionRespectoDolar;
            }
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.Cantidad/ Euro.Cotizacion);
        }
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.Cantidad / Peso.Cotizacion);
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - ((Dolar)p).cantidad);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + ((Dolar)p).cantidad);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.cantidad == (Dolar)p;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == (Dolar)e;
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
    }
}
