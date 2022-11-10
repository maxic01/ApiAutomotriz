using AutomotrizBackProg.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Datos.Interfaces
{
    public interface IFacturaDAO
    {
        List<Vendedor> getComboVendedor();
        List<Cliente> getComboCliente();
        List<FormaEntrega> getComboFormaEntrega();
        List<MedioPedido> getComboMedioPedido();
        List<FormaPago> getComboFormaPago();
        List<Producto> getComboProducto();
        List<TipoCliente> getComboTipoCliente();
        List<TipoDoc> getComboTipoDoc();
        List<Barrios> getComboBarrios();
        bool getInsertFactura(Factura factura);
        Factura getFactura(int nro);
        List<Factura> getFacturas();
        bool getInsertCliente(Cliente cliente);
        bool getDeleteCliente(int numero);
        bool getUpdateCliente(int numero, Cliente cliente);
        bool getInsertProducto(Producto producto);
        bool getDeleteProducto(int numero);
        bool getUpdateProducto(int numero, Producto producto);
        bool getUpdateFactura(int numero, Factura factura);
        bool getDeleteFactura(int numero);
        int getProximaFactura();
        List<Usuario> getUsuario();
    }
}
