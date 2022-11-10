using AutomotrizBackProg.Datos.Interfaces;
using AutomotrizBackProg.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AutomotrizBackProg.Datos.Implementaciones
{
    public class FacturaDAO : IFacturaDAO
    {
        public List<Cliente> getComboCliente()
        {
            List<Cliente> list = new List<Cliente>();
            DataTable tabla = DBHelper.obtenerInstancia().comboCliente();
            foreach (DataRow dr in tabla.Rows)
            {
                int id = int.Parse(dr["id_cliente"].ToString());
                string nombre = dr["nombre_completo"].ToString();
                string calle = dr["calle"].ToString();
                int altura = int.Parse(dr["altura"].ToString());
                int telefono = int.Parse(dr["telefono"].ToString());
                int tipocliente = int.Parse(dr["id_tipo_cliente"].ToString());
                int barrio = int.Parse(dr["id_barrio"].ToString());
                int tipodoc = int.Parse(dr["id_tipo_doc"].ToString());
                int doc = int.Parse(dr["nro_doc"].ToString());
                Cliente aux = new Cliente(id, nombre, calle, altura, telefono, tipocliente, barrio, tipodoc, doc);
                list.Add(aux);
            }
            return list;
        }
        public List<Vendedor> getComboVendedor()
        {
            List<Vendedor> list = new List<Vendedor>();
            DataTable tabla = DBHelper.obtenerInstancia().comboVendedor();
            foreach (DataRow dr in tabla.Rows)
            {
                int id = int.Parse(dr["id_vendedor"].ToString());
                string nombre = dr["nombre_completo"].ToString();
                string calle = dr["calle"].ToString();
                int altura = int.Parse(dr["altura"].ToString());
                int telefono = int.Parse(dr["telefono"].ToString());
                int barrio = int.Parse(dr["id_barrio"].ToString());
                int tipodoc = int.Parse(dr["id_tipo_doc"].ToString());
                int doc = int.Parse(dr["nro_doc"].ToString());
                Vendedor aux = new Vendedor(id, nombre, calle, altura, telefono, barrio, tipodoc, doc);
                list.Add(aux);
            }
            return list;
        }

        public List<FormaEntrega> getComboFormaEntrega()
        {
            List<FormaEntrega> list = new List<FormaEntrega>();
            DataTable tabla = DBHelper.obtenerInstancia().comboFormaEntrega();
            foreach (DataRow dr in tabla.Rows)
            {
                int id = int.Parse(dr["id_forma_entrega"].ToString());
                string nombre = dr["forma_entrega"].ToString();
                FormaEntrega aux = new FormaEntrega(id, nombre);
                list.Add(aux);
            }
            return list;
        }

        public List<FormaPago> getComboFormaPago()
        {
            List<FormaPago> list = new List<FormaPago>();
            DataTable tabla = DBHelper.obtenerInstancia().comboFormaPago();
            foreach (DataRow dr in tabla.Rows)
            {
                int id = int.Parse(dr["id_forma_pago"].ToString());
                string nombre = dr["forma_pago"].ToString();
                FormaPago aux = new FormaPago(id, nombre);
                list.Add(aux);
            }
            return list;
        }

        public List<MedioPedido> getComboMedioPedido()
        {
            List<MedioPedido> list = new List<MedioPedido>();
            DataTable tabla = DBHelper.obtenerInstancia().comboMedioPedido();
            foreach (DataRow dr in tabla.Rows)
            {
                int id = int.Parse(dr["id_medio_pedido"].ToString());
                string nombre = dr["medio_pedido"].ToString();
                MedioPedido aux = new MedioPedido(id, nombre);
                list.Add(aux);
            }
            return list;
        }

        public List<Producto> getComboProducto()
        {
            List<Producto> list = new List<Producto>();
            DataTable tabla = DBHelper.obtenerInstancia().comboProducto();
            foreach (DataRow dr in tabla.Rows)
            {
                int id = int.Parse(dr["id_producto"].ToString());
                string nombre = dr["descripcion"].ToString();
                double precio = double.Parse(dr["precio_unitario"].ToString());
                Producto aux = new Producto(id, nombre, precio);
                list.Add(aux);
            }
            return list;
        }
        public bool getInsertFactura(Factura factura)
        {
            return DBHelper.obtenerInstancia().insertFactura(factura);
        }

        public int getProximaFactura()
        {
            string sp = "ProximaFactura";
            return DBHelper.obtenerInstancia().ConsultaEscalarSQL(sp, "@next");
        }

        public bool getInsertCliente(Cliente cliente)
        {
            return DBHelper.obtenerInstancia().insertCliente(cliente);
        }

        public List<TipoCliente> getComboTipoCliente()
        {
            List<TipoCliente> list = new List<TipoCliente>();
            DataTable tabla = DBHelper.obtenerInstancia().comboTipoCliente();
            foreach (DataRow dr in tabla.Rows)
            {
                int id = int.Parse(dr["id_tipo_cliente"].ToString());
                string nombre = dr["nombre"].ToString();
                TipoCliente aux = new TipoCliente(id, nombre);
                list.Add(aux);
            }
            return list;
        }

        public List<TipoDoc> getComboTipoDoc()
        {
            List<TipoDoc> list = new List<TipoDoc>();
            DataTable tabla = DBHelper.obtenerInstancia().comboTipoDoc();
            foreach (DataRow dr in tabla.Rows)
            {
                int id = int.Parse(dr["id_tipo_doc"].ToString());
                string nombre = dr["tipo_doc"].ToString();
                TipoDoc aux = new TipoDoc(id, nombre);
                list.Add(aux);
            }
            return list;
        }

        public List<Barrios> getComboBarrios()
        {
            List<Barrios> list = new List<Barrios>();
            DataTable tabla = DBHelper.obtenerInstancia().comboBarrios();
            foreach (DataRow dr in tabla.Rows)
            {
                int idbarrio = int.Parse(dr["id_barrio"].ToString());
                string nombre = dr["nombre"].ToString();
                int id = int.Parse(dr["id_localidad"].ToString());
                Barrios aux = new Barrios(idbarrio, nombre, id);
                list.Add(aux);
            }
            return list;
        }

        public bool getInsertProducto(Producto producto)
        {
            return DBHelper.obtenerInstancia().insertProducto(producto);
        }

        public List<Factura> getFacturas()
        {
            List<Factura> list = new List<Factura>();
            DataTable tabla = DBHelper.obtenerInstancia().grillaFactura();
            foreach (DataRow dr in tabla.Rows)
            {
                int nrofactura = int.Parse(dr["nro_factura"].ToString());
                DateTime fecha = DateTime.Parse(dr["fecha"].ToString());
                int idvendedor = int.Parse(dr["id_vendedor"].ToString());
                int idcliente = int.Parse(dr["id_vendedor"].ToString());
                int identrega = int.Parse(dr["id_forma_entrega"].ToString());
                int idpedido = int.Parse(dr["id_medio_pedido"].ToString());
                int pago = int.Parse(dr["id_forma_pago"].ToString());
                Factura aux = new Factura(nrofactura, fecha, idvendedor, idcliente, identrega, idpedido, pago);
                list.Add(aux);
            }
            return list;
        }

        public Factura getFactura(int nro)
        {
            Factura factura = new Factura();
            string sp = "facturaIndividual";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@nrofactura", nro));
            DataTable tabla = DBHelper.obtenerInstancia().ConsultaSQL(sp, lst);
            bool primero = true;
            foreach (DataRow dr in tabla.Rows)
            {
                if (primero)
                {
                    factura.NroFactura = int.Parse(dr["nro_factura"].ToString());
                    factura.Fecha = DateTime.Parse(dr["fecha"].ToString());
                    factura.CodVendedor = int.Parse(dr["id_vendedor"].ToString());
                    factura.CodCliente = int.Parse(dr["id_cliente"].ToString());
                    factura.FormaEntrega = int.Parse(dr["id_forma_entrega"].ToString());
                    factura.FormaPedido = int.Parse(dr["id_medio_pedido"].ToString());
                    factura.FormaPago = int.Parse(dr["id_forma_pago"].ToString());
                    primero = false;
                }
                int id = int.Parse(dr["id_producto"].ToString());
                string nombre = dr["descripcion"].ToString();
                double precio = double.Parse(dr["precio_unitario"].ToString());
                Producto producto = new Producto(id, nombre, precio);
                int cantidad = int.Parse(dr["cantidad"].ToString());
                DetalleFactura detalle = new DetalleFactura(cantidad, producto);
                factura.agregarDetalle(detalle);
            }
            return factura;
        }

        public bool getDeleteProducto(int numero)
        {
            return DBHelper.obtenerInstancia().deleteProducto(numero);
        }

        public bool getDeleteCliente(int numero)
        {
            return DBHelper.obtenerInstancia().deleteCliente(numero);
        }

        public bool getUpdateCliente(int numero, Cliente cliente)
        {
            return DBHelper.obtenerInstancia().updateCliente(numero, cliente);
        }

        public bool getUpdateProducto(int numero, Producto producto)
        {
            return DBHelper.obtenerInstancia().updateProducto(numero, producto);
        }

        public List<Usuario> getUsuario()
        {
            List<Usuario> list = new List<Usuario>();
            DataTable tabla = DBHelper.obtenerInstancia().Login();
            foreach (DataRow dr in tabla.Rows)
            {
                string usuario = dr["usuario"].ToString();
                string contrasenia = dr["contrasenia"].ToString();
                Usuario aux = new Usuario(usuario,contrasenia);
                list.Add(aux);
            }
            return list;
        }

        public bool getUpdateFactura(int numero,Factura factura)
        {
            return DBHelper.obtenerInstancia().updateFactura(numero,factura);
        }

        public bool getDeleteFactura(int numero)
        {
            return DBHelper.obtenerInstancia().deleteFactura(numero);
        }
    }
}
