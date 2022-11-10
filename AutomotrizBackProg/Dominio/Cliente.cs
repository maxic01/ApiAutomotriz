using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public int Telefono { get; set; }
        public int Idtipo { get; set; }
        public int IdBarrio { get; set; }
        public int IdTipoDoc { get; set; }
        public int NroDoc { get; set; }
        public Cliente()
        {

        }
        public Cliente(int id, string nombre, string calle, int altura, int telefono, int idtipo, int idbarrio, int idtipodoc, int nrodoc)
        {
            IdCliente = id;
            Nombre = nombre;
            Calle = calle;
            Altura = altura;
            Telefono = telefono;
            Idtipo = idtipo;
            IdBarrio = idbarrio;
            IdTipoDoc = idtipodoc;
            NroDoc = nrodoc;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
