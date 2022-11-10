using AutomotrizBackProg.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAutoProg.Servicios.Interfaces
{
    public interface IServicio
    {
        List<Vendedor> comboVendedor();
        List<Cliente> comboCliente();
        List<FormaEntrega> comboFormaEntrega();
        List<MedioPedido> comboMedioPedido();
        List<FormaPago> comboFormaPago();
        List<Producto> comboProducto();
        List<TipoDoc> comboTipoDoc();
        List<Barrios> comboBarrios();
        List<TipoCliente> comboTipoCliente();
        List<Factura> Facturas();
        List<Usuario> Login();
        Factura FacturaPorNumero(int numero);
        bool insertFactura(Factura factura);
        bool updateFactura(int numero, Factura factura);
        bool deleteFactura(int numero);
        bool insertCliente(Cliente cliente);
        bool deleteCliente(int numero);
        bool updateCliente(int numero, Cliente cliente);
        bool insertProducto(Producto producto);
        bool deleteProducto(int numero);
        bool updateProducto(int numero, Producto producto);
        int ProximaFactura();
    }
}
