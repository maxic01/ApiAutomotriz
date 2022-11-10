using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class FormaEntrega
    {
        public int IdFormaEntrega { get; set; }
        public string Descripcion { get; set; }
        public FormaEntrega()
        {

        }
        public FormaEntrega(int id, string descripcion)
        {
            IdFormaEntrega = id;
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
