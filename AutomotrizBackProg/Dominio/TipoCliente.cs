using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class TipoCliente
    {
        public int IdTipoCliente { get; set; }
        public string Nombre { get; set; }
        public TipoCliente(int id, string nombre)
        {
            IdTipoCliente = id;
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
