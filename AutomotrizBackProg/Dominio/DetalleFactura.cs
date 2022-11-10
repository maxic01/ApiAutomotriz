using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class DetalleFactura
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }

        public DetalleFactura(int cantidad, Producto producto)
        {
            Cantidad = cantidad;
            Producto = producto;

        }
        public DetalleFactura()
        {

        }
        public double CalcularSubTotal()
        {
            return Producto.Precio * Cantidad;
        }
    }
}
