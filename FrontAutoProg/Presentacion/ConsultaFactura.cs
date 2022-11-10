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
    public partial class ConsultaFactura : Form
    {
        private IServicio servicio;

        private static ConsultaFactura instancia = null;
        public static ConsultaFactura obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new ConsultaFactura();
            }
            return instancia;
        }
        public ConsultaFactura()
        {
            InitializeComponent();
            servicio = new ImplementacionFactory().crearServicio();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            grillaFacturas();
        }
        public async void grillaFacturas()
        {
            string url = "http://localhost:5198/Facturas";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Factura>>(data);
            dgvFacturas.DataSource = lst;
            DataGridViewButtonColumn detalles = new DataGridViewButtonColumn();
            detalles.HeaderText = "Acciones";
            detalles.Name = "colDetalle";
            detalles.Text = "Ver Detalles";
            detalles.UseColumnTextForButtonValue = true;
            dgvFacturas.Columns.Add(detalles);
        }

        private void dgvFacturas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;

            if (dgvFacturas.CurrentCell.ColumnIndex == 7)
            {
                int nro = int.Parse(dgvFacturas.CurrentRow.Cells["nroFactura"].Value.ToString());
                new ConsultaDetalleF(nro).ShowDialog();
                Dispose();
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

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvFacturas.CurrentRow.Cells["nroFactura"].Value.ToString());
            await EliminarFacturaAsync(id);
        }
        private async Task EliminarFacturaAsync(int id)
        {
            if (MessageBox.Show("Seguro que desea eliminar la factura seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvFacturas.CurrentRow != null)
                {
                    string url = "http://localhost:5198/EliminarFactura?id=" + id;
                    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("Factura eliminada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ERROR. No se pudo eliminar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ConsultaFactura_Load(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
