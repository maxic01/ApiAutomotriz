using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class MedioPedido
    {
        public int IdMedio { get; set; }
        public string Descripcion { get; set; }
        public MedioPedido()
        {

        }
        public MedioPedido(int id, string descripcion)
        {
            IdMedio = id;
            Descripcion = descripcion;
        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
