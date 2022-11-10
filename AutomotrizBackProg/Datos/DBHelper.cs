using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AutomotrizBackProg.Dominio;

namespace AutomotrizBackProg.Datos
{
    public class DBHelper : acceso
    {
        private static DBHelper instancia;
        public static DBHelper obtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new DBHelper();
            }
            return instancia;
        }
        #region combos
        public DataTable comboVendedor()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "cargarVendedor";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable comboCliente()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "cargarCliente";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable comboFormaEntrega()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "cargarForma_Entrega";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable comboMedioPedido()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "cargarMedio_Pedido";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }

        public DataTable comboFormaPago()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "cargarForma_Pago";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable comboProducto()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "cargarProducto";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable comboTipoCliente()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "tipoCliente";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable comboBarrios()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "cargarBarrios";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable comboTipoDoc()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "cargarTipoDoc";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable grillaFactura()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "consultaFactura";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable Login()
        {
            comando.Parameters.Clear();
            conectar();
            comando.CommandText = "SP_USUARIOS";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable ConsultaSQL(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            conectar();
            SqlCommand cmd = new SqlCommand(spNombre, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            desconectar();

            return tabla;
        }
        #endregion

        public bool insertFactura(Factura factura)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "insert_Factura";
                comando.Parameters.AddWithValue("@fecha", factura.Fecha);
                comando.Parameters.AddWithValue("@cod_vendedor", factura.CodVendedor);
                comando.Parameters.AddWithValue("@cod_cliente", factura.CodCliente);
                comando.Parameters.AddWithValue("@forma_entrega", factura.FormaEntrega);
                comando.Parameters.AddWithValue("@forma_pedido", factura.FormaPedido);
                comando.Parameters.AddWithValue("@forma_pago", factura.FormaPago);
                comando.Parameters.AddWithValue("@total", factura.CalcularTotal());
                SqlParameter parametro = new SqlParameter("@id", SqlDbType.Int);
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);
                comando.ExecuteNonQuery();
                int idFactura = (int)parametro.Value;
                foreach (DetalleFactura detalle in factura.DetalleFactura)
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "insert_Detalle";
                    comando.Parameters.AddWithValue("@nro_factura", idFactura);
                    comando.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    comando.Parameters.AddWithValue("@cod_producto", detalle.Producto.IdProducto);
                    comando.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;

            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public bool updateFactura(int numero,Factura factura)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "updateFactura";
                comando.Parameters.AddWithValue("@formaentrega", factura.FormaEntrega);
                comando.Parameters.AddWithValue("@nrofactura", numero);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;

            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public bool insertCliente(Cliente cliente)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "insertCliente";
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@calle", cliente.Calle);
                comando.Parameters.AddWithValue("@altura", cliente.Altura);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@tipocliente", cliente.Idtipo);
                comando.Parameters.AddWithValue("@idbarrio", cliente.IdBarrio);
                comando.Parameters.AddWithValue("@tipodoc", cliente.IdTipoDoc);
                comando.Parameters.AddWithValue("@nrodoc", cliente.NroDoc);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public bool deleteCliente(int numero)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "eliminarCliente";
                comando.Parameters.AddWithValue("@idcliente", numero);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public bool deleteFactura(int numero)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "deleteFactura";
                comando.Parameters.AddWithValue("@nrofactura", numero);
                comando.ExecuteNonQuery();




                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public bool updateCliente(int numero, Cliente cliente)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "editarCliente";
                comando.Parameters.AddWithValue("@idcliente", numero);
                comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
                comando.Parameters.AddWithValue("@calle", cliente.Calle);
                comando.Parameters.AddWithValue("@altura", cliente.Altura);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public bool insertProducto(Producto producto)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "insertProducto";
                comando.Parameters.AddWithValue("@nombre", producto.Descripcion);
                comando.Parameters.AddWithValue("@precio", producto.Precio);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public bool deleteProducto(int numero)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "eliminarProducto";
                comando.Parameters.AddWithValue("@idProducto", numero);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public bool updateProducto(int numero, Producto producto)
        {
            bool ok = true;
            SqlTransaction t = null;
            try
            {
                conectar();
                comando.Parameters.Clear();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "editarProducto";
                comando.Parameters.AddWithValue("@idproducto", numero);
                comando.Parameters.AddWithValue("@precio", producto.Precio);
                comando.ExecuteNonQuery();
                t.Commit();
            }
            catch (Exception)
            {
                t.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        public int ConsultaEscalarSQL(string spNombre, string pOutNombre)
        {
            conectar();
            SqlCommand cmd = new SqlCommand(spNombre, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = pOutNombre;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            desconectar();

            return (int)pOut.Value;
        }
    }
}
