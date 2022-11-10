using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class Barrios
    {
        public int IdBarrio { get; set; }
        public string Nombre { get; set; }
        public int IdLocalidad { get; set; }
        public Barrios(int idbarrio, string nombre, int idlocalidad)
        {
            IdBarrio = idbarrio;
            Nombre = nombre;
            IdLocalidad = idlocalidad;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
