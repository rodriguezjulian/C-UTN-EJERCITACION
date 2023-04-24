using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private static double cotizacionRespectoDolar;
        private double cantidad;

        static Peso()
        {
            Peso.cotizacionRespectoDolar =102.65f;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        //SOBRECARGO
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizacionRespectoDolar = cotizacion;
        }
        public double Cantidad
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
            set 
            {
                cotizacionRespectoDolar = value;
            }
        }

        public static explicit operator Peso(Euro e)
        {
            return new Peso((e.Cantidad/ Euro.Cotizacion)*Peso.Cotizacion);
        }
         
        public static explicit operator Peso(Dolar p)
        {
            return new Peso(p.Cantidad * Peso.Cotizacion);
        }
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - ((Peso)e).cantidad);
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - ((Peso)d).cantidad);
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + ((Peso)e).cantidad);
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + ((Peso)d).cantidad);
        }
       public static bool operator ==(Peso p, Dolar d)
        {
            return p == (Peso)d;
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p == (Peso)e;
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
    }
}
