using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public int CodVendedor { get; set; }
        public int CodCliente { get; set; }
        public int FormaEntrega { get; set; }
        public int FormaPedido { get; set; }
        public int FormaPago { get; set; }
        public List<DetalleFactura> DetalleFactura { get; set; }
        public Factura()
        {
            DetalleFactura = new List<DetalleFactura>();
        }
        public Factura(int nrofactura, DateTime fecha, int vendedor, int cliente, int entrega, int pedido, int pago)
        {
            NroFactura = nrofactura;
            Fecha = fecha;
            CodVendedor = vendedor;
            CodCliente = cliente;
            FormaEntrega = entrega;
            FormaPago = pago;
            FormaPedido = pedido;
        }
        public void agregarDetalle(DetalleFactura detalle)
        {
            DetalleFactura.Add(detalle);
        }
        public void quitarDetalle(int index)
        {
            DetalleFactura.RemoveAt(index);
        }
        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura item in DetalleFactura)
                total += item.CalcularSubTotal();
            return total;
        }
    }
}
