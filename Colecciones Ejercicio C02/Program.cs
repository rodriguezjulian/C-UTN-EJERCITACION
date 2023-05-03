using Motores;

namespace Colecciones_Ejercicio_C02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoF1 autoUno = new AutoF1(5, "Ferrari");
            AutoF1 autoDos = new AutoF1(6, "Ford");
            AutoF1 autoTres = new AutoF1(9, "Chevrolet");
            AutoF1 autoCuatro = new AutoF1(4, "Fiat");
            AutoF1 autoCinco = new AutoF1(8, "Honda");
            AutoF1 autoSeis = new AutoF1(8, "Tesla");

            Competencia primavera = new Competencia(8, 4);

        }
    }
}