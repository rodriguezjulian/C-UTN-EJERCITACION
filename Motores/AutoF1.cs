using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motores
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string? escuderia;
        private short numero;
        private short vueltasRestantes;

        //CREO UN CONSTRUCTOR SIN PARAMETROS PARA CREAR UNA INSTANCIA DE LA CLASE Y ESTABLECER VALORES PREDETERMINADOS
        public AutoF1() : this(0, string.Empty)
        {

        }
        private AutoF1(short cantidadCombustible, bool enCompetencia, short vueltasRestantes)
        {
            this.cantidadCombustible = cantidadCombustible;
            this.enCompetencia = enCompetencia;
            this.vueltasRestantes = vueltasRestantes;
        }
        public AutoF1(short numero, string escuderia) : this(0, false, 0)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        public short CantidadCombustible
        {
            get 
            {
                return this.cantidadCombustible;
            }
            set
            {
                cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                enCompetencia=value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                vueltasRestantes=value;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto" + this.numero);
            sb.AppendLine("Escuderia" + this.escuderia);
            sb.AppendLine("Vueltas restantes" + this.vueltasRestantes);
            return sb.ToString();

        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }
    }
}
