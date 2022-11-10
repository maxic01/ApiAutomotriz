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
    public partial class ConsultaDetalleF : Form
    {
        private Factura nueva;
        private IServicio servicio;
        private int facturanro;
        private ConsultaFactura consultarF;
        
        public ConsultaDetalleF(int facturanro)
        {
            InitializeComponent();
            servicio = new ImplementacionFactory().crearServicio();
            this.facturanro = facturanro;
            nueva = new Factura();
            consultarF = new ConsultaFactura();
        }

        private async void ConsultaDetalleF_Load_1(object sender, EventArgs e)
        {
            await comboFormaEntrega();
            this.Text = this.Text + facturanro.ToString();
            Factura factura = servicio.FacturaPorNumero(facturanro);
            txtFecha.Text = factura.Fecha.ToString("dd/MM/yyyy");
            txtFecha.Enabled = false;
            txtCliente.Enabled = false;
            txtCliente.Text = factura.CodCliente.ToString();

            foreach (DetalleFactura detalle in factura.DetalleFactura)
            {
                dgvDetalleF.Rows.Add(new object[] {factura.NroFactura, detalle.Producto.Descripcion, detalle.Cantidad, detalle.Producto.Precio });
            }
        }
        
        private async Task comboFormaEntrega()
        {
            string url = "http://localhost:5198/FormaEntrega";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<FormaEntrega>>(data);
            cboEntrega.DataSource = lst;
            cboEntrega.DisplayMember = "Descripcion";
            cboEntrega.ValueMember = "IdFormaEntrega";
            cboEntrega.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDetalleF.CurrentRow.Cells["colFactura"].Value.ToString());
            await EditarFacturaAsync(id);
        }
        
        private async Task EditarFacturaAsync(int id)
        {
            if (MessageBox.Show("Seguro que desea actualizar la factura seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvDetalleF.CurrentRow != null)
                {
                    nueva.FormaEntrega = (int)cboEntrega.SelectedValue;
                    string bodyContent = JsonConvert.SerializeObject(nueva);
                    string url = "http://localhost:5198/EditarFactura?numero=" + id;
                    var result = await ClienteSingleton.GetInstance().PutAsync(url, bodyContent);

                    if (result.Equals("true"))
                    {
                        MessageBox.Show("Factura actualizada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ERROR. No se pudo actualizar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
