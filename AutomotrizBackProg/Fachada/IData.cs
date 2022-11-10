using AutomotrizBackProg.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Fachada
{
    public interface IData
    {
        List<Producto> getProductos();
        List<Cliente> getCliente();
        List<Vendedor> getVendedor();
        List<FormaEntrega> getFormaEntrega();
        List<FormaPago> getFormaPago();
        List<MedioPedido> getMedioPedido();
        List<Barrios> getBarrios();
        List<TipoDoc> getTipoDoc();
        List<TipoCliente> getTipoCliente();
        List<Factura> getFacturas();
        Factura getFactura(int numero);
        bool saveFactura(Factura factura);
        bool saveCliente(Cliente cliente);
        bool deleteCliente(int numero);
        bool updateCliente(int numero, Cliente cliente);
        bool saveProducto(Producto producto);
        bool deleteProducto(int numero);
        bool updateProducto(int numero, Producto producto);
        bool updateFactura(int numero, Factura factura);
        bool deleteFactura(int numero);
    }
}
