using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Producto(int id, string descripcion, double precio)
        {
            IdProducto = id;
            Descripcion = descripcion;
            Precio = precio;
        }
        public Producto()
        {

        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
