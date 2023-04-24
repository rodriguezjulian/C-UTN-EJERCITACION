using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06_Objetos
{
    internal class Cuenta
    {
        //Estos atributos pueden ser publicos privados etc
        //dar visibilidad a los atributos privados a traves de getters y setters
        #region "Atributos"
        string? titular;
        float cantidad;
        #endregion

        //INICIALIZAR VALORES con constructor - Puedo tener muchos constructores
        public Cuenta()
        {
            this.titular = "jorgito";
            this.cantidad = 120000;// = SaldoDeCuenta
        }
        //NO ARMO SETTERS, SOLO VOY A LEER DATOS
        public float SaldoDeCuenta
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }
        public string Titular
        {
            get
            {
                return this.Titular;
            }
        }
        #region "Ingreso datos"
        public static int IngresarNumero(string mensaje)
        {
            int operacion;
            int bandera = 0;
            do
            {
                Console.WriteLine(mensaje);
                if ((int.TryParse(Console.ReadLine(), out operacion) == true))
                {
                    bandera = 1;
                }
                else
                {
                    Console.WriteLine("ERROR, Ingresar numero.");
                }
            } while (bandera == 0);
            return operacion;
        }
        public static int IngresarNumeroRango(string mensaje, int min, int max)
        {
            int numeroIngresado;
            int bandera = 0;
            do
            {
                Console.WriteLine(mensaje);
                if ((int.TryParse(Console.ReadLine(), out numeroIngresado) == true) && numeroIngresado >= min && numeroIngresado <= max)
                {
                    bandera = 1;
                }
                else
                {
                    Console.WriteLine("ERROR, Reingresar numero.");
                }
            } while (bandera == 0);
            return numeroIngresado;
        }
        public static float IngresarNumeroFloat(string mensaje)
        {
            float operacion;
            int bandera = 0;
            do
            {
                Console.WriteLine(mensaje);
                if ((float.TryParse(Console.ReadLine(), out operacion) == true))
                {
                    bandera = 1;
                }
                else
                {
                    Console.WriteLine("ERROR, Ingresar numero.");
                }
            } while (bandera == 0);
            return operacion;
        }
        #endregion

        public void MostrarCuenta()
        {
            Console.WriteLine($"Numero de cuenta: {this.titular} - Saldo: {this.cantidad}");
        }
        public void ingresarMonto(float numeroIngresado) 
        {
            if (numeroIngresado>0) 
            {
                SaldoDeCuenta = SaldoDeCuenta + numeroIngresado;
                Console.WriteLine("\nNUEVOS DATOS DE LA CUENTA:");
                MostrarCuenta();
            }
        }
        public void retirarMonto(float numeroIngresado)
        {
         
            SaldoDeCuenta = SaldoDeCuenta - numeroIngresado;
            Console.WriteLine("\nNUEVOS DATOS DE LA CUENTA:");
            MostrarCuenta();    
        }

    }
}
