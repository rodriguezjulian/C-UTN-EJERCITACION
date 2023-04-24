using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private static double cotizacionRespectoDolar;
        private double cantidad;

        static Euro() 
        {
            Euro.cotizacionRespectoDolar =1.17;
        }
        public Euro(double cantidad) 
        {
            this.cantidad = cantidad;
        }
        //SOBRECARGO
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizacionRespectoDolar = cotizacion;
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
        public static explicit operator Euro(Dolar p)
        {
            return new Euro(p.Cantidad * Euro.Cotizacion);
        }
        public static explicit operator Euro(Peso e)
        {
            return new Euro((e.Cantidad / Peso.Cotizacion)*Euro.Cotizacion);
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }


        //COMO TRABAJO CON COTIZACION RESPECTO AL USD, PASO NUEVAMENTE EL PESO AL EURO 
        //QUE YA ESTA PASADO A USD
       /* public static explicit operator Peso(Euro e)
         {
             return (Peso)((Euro)e;
         }*/

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e == (Euro)p;
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e == (Euro)d;
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
    }

}
