using AutomotrizBackProg.Datos.Implementaciones;
using AutomotrizBackProg.Datos.Interfaces;
using AutomotrizBackProg.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Fachada
{
    public class DataLib : IData
    {
        private IFacturaDAO dao;
        public DataLib()
        {
            dao = new FacturaDAO();
        }

        public bool deleteCliente(int numero)
        {
            return dao.getDeleteCliente(numero);
        }

        public bool deleteFactura(int numero)
        {
            return dao.getDeleteFactura(numero);
        }

        public bool deleteProducto(int numero)
        {
            return dao.getDeleteProducto(numero);
        }

        public List<Barrios> getBarrios()
        {
            return dao.getComboBarrios();
        }

        public List<Cliente> getCliente()
        {
            return dao.getComboCliente();
        }

        public Factura getFactura(int numero)
        {
            return dao.getFactura(numero);
        }

        public List<Factura> getFacturas()
        {
            return dao.getFacturas();
        }

        public List<FormaEntrega> getFormaEntrega()
        {
            return dao.getComboFormaEntrega();
        }

        public List<FormaPago> getFormaPago()
        {
            return dao.getComboFormaPago();
        }
        public List<MedioPedido> getMedioPedido()
        {
            return dao.getComboMedioPedido();
        }

        public List<Producto> getProductos()
        {
            return dao.getComboProducto();
        }

        public List<TipoCliente> getTipoCliente()
        {
            return dao.getComboTipoCliente();
        }

        public List<TipoDoc> getTipoDoc()
        {
            return dao.getComboTipoDoc();
        }

        public List<Vendedor> getVendedor()
        {
            return dao.getComboVendedor();
        }

        public bool saveCliente(Cliente cliente)
        {
            return dao.getInsertCliente(cliente);
        }

        public bool saveFactura(Factura factura)
        {
            return dao.getInsertFactura(factura);
        }

        public bool saveProducto(Producto producto)
        {
            return dao.getInsertProducto(producto);
        }

        public bool updateCliente(int numero, Cliente cliente)
        {
            return dao.getUpdateCliente(numero, cliente);
        }

        public bool updateFactura(int numero, Factura factura)
        {
            return dao.getUpdateFactura(numero, factura);
        }

        public bool updateProducto(int numero, Producto producto)
        {
            return dao.getUpdateProducto(numero, producto);
        }
    }
}
