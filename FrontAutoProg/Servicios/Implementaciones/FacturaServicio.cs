using AutomotrizBackProg.Datos.Implementaciones;
using AutomotrizBackProg.Datos.Interfaces;
using AutomotrizBackProg.Dominio;
using FrontAutoProg.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAutoProg.Servicios.Implementaciones
{
    public class FacturaServicio : IServicio
    {
        private IFacturaDAO DAO;
        public FacturaServicio()
        {
            DAO = new FacturaDAO();
        }

        public List<Barrios> comboBarrios()
        {
            return DAO.getComboBarrios();
        }

        public List<Cliente> comboCliente()
        {
            return DAO.getComboCliente();
        }

        public List<FormaEntrega> comboFormaEntrega()
        {
            return DAO.getComboFormaEntrega();
        }

        public List<FormaPago> comboFormaPago()
        {
            return DAO.getComboFormaPago();
        }


        public List<MedioPedido> comboMedioPedido()
        {
            return DAO.getComboMedioPedido();
        }

        public List<Producto> comboProducto()
        {
            return DAO.getComboProducto();
        }

        public List<TipoCliente> comboTipoCliente()
        {
            return DAO.getComboTipoCliente();
        }

        public List<TipoDoc> comboTipoDoc()
        {
            return DAO.getComboTipoDoc();
        }

        public List<Vendedor> comboVendedor()
        {
            return DAO.getComboVendedor();
        }

        public bool deleteCliente(int numero)
        {
            return DAO.getDeleteCliente(numero);
        }

        public bool deleteFactura(int numero)
        {
            return DAO.getDeleteFactura(numero);
        }

        public bool deleteProducto(int numero)
        {
            return DAO.getDeleteProducto(numero);
        }

        public Factura FacturaPorNumero(int numero)
        {
            return DAO.getFactura(numero);
        }

        public List<Factura> Facturas()
        {
            return DAO.getFacturas();
        }

        public bool insertCliente(Cliente cliente)
        {
            return DAO.getInsertCliente(cliente);
        }

        public bool insertFactura(Factura factura)
        {
            return DAO.getInsertFactura(factura);
        }

        public bool insertProducto(Producto producto)
        {
            return DAO.getInsertProducto(producto);
        }

        public List<Usuario> Login()
        {
            return DAO.getUsuario();
        }

        public int ProximaFactura()
        {
            return DAO.getProximaFactura();
        }

        public bool updateCliente(int numero, Cliente cliente)
        {
            return DAO.getUpdateCliente(numero, cliente);
        }

        public bool updateFactura(int numero, Factura factura)
        {
            return DAO.getUpdateFactura(numero,factura);
        }

        public bool updateProducto(int numero, Producto producto)
        {
            return DAO.getUpdateProducto(numero, producto);
        }
    }
}
