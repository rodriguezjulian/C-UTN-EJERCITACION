using System.Text;

namespace Motores
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        private List<AutoF1> competidores;


        //inicializar un objeto de la clase Competencia y establecer el campo competidores como una nueva
        //lista vacía de objetos de la clase AutoF1.
        private Competencia()
       {
            this.competidores = new List<AutoF1>();
       }
        public Competencia(short cantidadCompetidores, short cantidadVuletas) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVuletas;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------COMPETENCIA------");              
            sb.AppendLine("COMPETIDORES: " + this.cantidadCompetidores);
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine("----------------------");
                sb.AppendLine(auto.MostrarDatos());
                sb.AppendLine("----------------------");
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    return true;
                }
            }
            return false;

        }
        public static bool operator !=(Competencia c, AutoF1 auto)
        {
            foreach (AutoF1 a in c.competidores)
            {
                if (a == auto)
                {
                    return false;
                }
            }
            return true;

        }
        public static bool operator -(Competencia compe, AutoF1 auto)
        {
            if (compe == auto)
            {
                compe.competidores.Remove(auto);
                return true;
            }
            return false;
        }
        public static bool operator +(Competencia compe, AutoF1 auto)
        {
            if (compe.competidores.Count < compe.cantidadCompetidores && compe != a)
            {
                compe.competidores.Add(auto);
                auto.EnCompetencia = true;
                auto.VueltasRestantes = compe.cantidadVueltas;
                Random rdn = new Random();
                auto.CantidadCombustible = (short)rdn.Next(15, 100);
                return true;
            }
            return false;
        }
    }
}