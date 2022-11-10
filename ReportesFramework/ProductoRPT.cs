using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportesFramework
{
    internal class ProductoRPT
    {
        public int Producto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public ProductoRPT(int id, string descripcion, double precio)
        {
            Producto = id;
            Descripcion = descripcion;
            Precio = precio;
        }
        public ProductoRPT()
        {

        }
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
