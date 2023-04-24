using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Windows_Form
{
    internal class Persona
    {
        String _nombre;
        int _edad;
        String _genero;
        String _estadoCivil;
        bool _futbol;
        bool _tenis;
        bool _natacion;
        public Persona(String nombre, int edad,String genero,String estadoCivil,
            bool futbol, bool tenis, bool natacion)
        {
            _nombre= nombre;
            _edad = edad;
            _genero = genero;
            _estadoCivil = estadoCivil;
            _futbol = futbol;
            _tenis = tenis;
            _natacion = natacion;
        }
        public override string ToString()
        {
            StringBuilder miCadena = new StringBuilder();
            miCadena.AppendLine("Datos");
            miCadena.AppendLine(_nombre);
            miCadena.AppendLine(_edad.ToString());
            miCadena.AppendLine(_genero);
            miCadena.AppendLine(_estadoCivil);
            if (_futbol)
            {
                miCadena.AppendLine("Futbol");
            }
            if (_tenis)
            {
                miCadena.AppendLine("tenis");
            }
            if (_natacion)
            {
                miCadena.AppendLine("natacion");
            }
            return miCadena.ToString();
        }
    }
}
