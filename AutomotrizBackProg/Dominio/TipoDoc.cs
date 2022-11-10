using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class TipoDoc
    {
        public int IdTipoDoc { get; set; }
        public string Tipo { get; set; }
        public TipoDoc(int id, string tipo)
        {
            IdTipoDoc = id;
            Tipo = tipo;
        }
        public override string ToString()
        {
            return Tipo;
        }
    }
}
