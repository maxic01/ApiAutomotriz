using AutomotrizBackProg.Dominio;
using FrontAutoProg.Servicios;
using FrontAutoProg.Servicios.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontAutoProg.Presentacion
{
    public partial class ConsultaProducto : Form
    {
        private IServicio servicio;
        Producto producto;

        private static ConsultaProducto instancia = null;
        public static ConsultaProducto obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new ConsultaProducto();
            }
            return instancia;
        }
        public ConsultaProducto()
        {
            InitializeComponent();
            servicio = new ImplementacionFactory().crearServicio();
            producto = new Producto();
        }

        private async void btnConsultar_Click_1(object sender, EventArgs e)
        {
            await grillaProducto();
        }
        private async Task grillaProducto()
        {
            string url = "http://localhost:5198/Productos";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(data);
            dgvProducto.DataSource = lst;            
        }

        private async void btnBorrar_Click_1(object sender, EventArgs e)
        {                
            int id = int.Parse(dgvProducto.CurrentRow.Cells["idProducto"].Value.ToString());
            await EliminarProductoAsync(id);            
        }

        private async Task EliminarProductoAsync(int id)
        {
            if (MessageBox.Show("Seguro que desea eliminar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvProducto.CurrentRow != null)
                {
                    string url = "http://localhost:5198/EliminarProducto?idProducto=" + id;
                    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("Producto eliminado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ERROR. No se pudo eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnEditar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvProducto.CurrentRow.Cells["idProducto"].Value.ToString());
            await EditarProductoAsync(id);            
        }
        private async Task EditarProductoAsync(int id)
        {
            if (MessageBox.Show("Seguro que desea actualizar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvProducto.CurrentRow != null)
                {
                    producto.Precio = Convert.ToInt32(txtPrecio.Text);
                    string bodyContent = JsonConvert.SerializeObject(producto);

                    string url = "http://localhost:5198/EditarProducto?idProducto=" + id;
                    var result = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("Producto actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ERROR. No se pudo actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void ConsultaProducto_Load(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
        }
    }
}
