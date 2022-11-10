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
    public partial class ConsultaClientes : Form
    {
        private IServicio servicio;
        Cliente cliente;

        private static ConsultaClientes instancia = null;
        public static ConsultaClientes obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new ConsultaClientes();
            }
            return instancia;
        }
        public ConsultaClientes()
        {
            InitializeComponent();
            servicio = new ImplementacionFactory().crearServicio();
            cliente = new Cliente();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private async void btnConsultar_Click_1(object sender, EventArgs e)
        {
            await grillaCliente();
        }
        private async Task grillaCliente()
        {
            string url = "http://localhost:5198/Clientes";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            dgvCliente.DataSource = lst;
        }

        private async void btnEditar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCliente.CurrentRow.Cells["IdCliente"].Value.ToString());
            await EditarClienteAsync(id);
        }
        private async Task EditarClienteAsync(int id)
        {
            if (MessageBox.Show("Seguro que desea actualizar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvCliente.CurrentRow != null)
                {
                    cliente.Telefono = Convert.ToInt32(txtNroTel.Text);
                    cliente.Calle = txtCalle.Text;
                    cliente.Altura = Convert.ToInt32(txtAltura.Text);
                    string bodyContent = JsonConvert.SerializeObject(cliente);

                    string url = "http://localhost:5198/EditarCliente?idCliente=" + id;
                    var result = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("Cliente actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ERROR. No se pudo actualizar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnBorrar_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvCliente.CurrentRow.Cells["IdCliente"].Value.ToString());
            await EliminarClienteAsync(id);
        }
        private async Task EliminarClienteAsync(int id)
        {
            if (MessageBox.Show("Seguro que desea eliminar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvCliente.CurrentRow != null)
                {                    
                    string url = "http://localhost:5198/EliminarCliente?idCliente=" + id;
                    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("Cliente eliminado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ERROR. No se pudo eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
