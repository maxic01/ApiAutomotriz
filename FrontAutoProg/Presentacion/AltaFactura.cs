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
    public partial class AltaFactura : Form
    {
        private IServicio servicio;
        private Factura nueva;
        private static AltaFactura instancia = null;
        public static AltaFactura obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new AltaFactura();
            }
            return instancia;
        }

        public AltaFactura()
        {
            InitializeComponent();
            servicio = new ImplementacionFactory().crearServicio();
            nueva = new Factura();
        }

        private void proximaFactura()
        {
            int next = servicio.ProximaFactura();
            if (next > 0)
                lblProxima.Text = "Factura Nº: " + next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiarCampos()
        {
            txtTotal.Text = string.Empty;
            cboCliente.SelectedIndex = -1;
            cboEntrega.SelectedIndex = -1;
            cboPago.SelectedIndex = -1;
            cboPedido.SelectedIndex = -1;
            cboProducto.SelectedIndex = -1;
            cboVendedor.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Today;
            nudCantidad.Value = 1;
            dgvDetalles.Rows.Clear();
            proximaFactura();
        }

        private async Task comboProducto()
        {
            string url = "http://localhost:5198/Productos";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(data);
            cboProducto.DataSource = lst;
            cboProducto.DisplayMember = "Descripcion";
            cboProducto.ValueMember = "IdProducto";
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task comboFormaPago()
        {
            string url = "http://localhost:5198/FormaPago";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<FormaPago>>(data);
            cboPago.DataSource = lst;
            cboPago.DisplayMember = "Descripcion";
            cboPago.ValueMember = "IdFormaPago";
            cboPago.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task comboMedioPedido()
        {
            string url = "http://localhost:5198/MedioPedido";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<MedioPedido>>(data);
            cboPedido.DataSource = lst;
            cboPedido.DisplayMember = "Descripcion";
            cboPedido.ValueMember = "IdMedio";
            cboPedido.DropDownStyle = ComboBoxStyle.DropDownList;
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

        private async Task comboCliente()
        {
            string url = "http://localhost:5198/Clientes";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            cboCliente.DataSource = lst;
            cboCliente.DisplayMember = "Nombre";
            cboCliente.ValueMember = "IdCliente";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task ComboVendedor()
        {
            string url = "http://localhost:5198/Vendedores";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject(data);
            cboVendedor.DataSource = lst;
            cboVendedor.DisplayMember = "Nombre";
            cboVendedor.ValueMember = "IdVendedor";
            cboVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task GuardarFacturaAsync()
        {
            nueva.Fecha = dtpFecha.Value;
            nueva.FormaPago = (int)cboPago.SelectedValue;
            nueva.FormaPedido = (int)cboPedido.SelectedValue;
            nueva.FormaEntrega = (int)cboEntrega.SelectedValue;
            nueva.CodVendedor = (int)cboVendedor.SelectedIndex;
            nueva.CodCliente = (int)cboCliente.SelectedIndex;
            
            string bodyContent = JsonConvert.SerializeObject(nueva);
            string url = "http://localhost:5198/Factura";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Factura registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
                Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularTotal()
        {
            double total = nueva.CalcularTotal();
            txtTotal.Text = total.ToString();
        }

        private void totalProductos()
        {
            int total = dgvDetalles.Rows.Count;
            txtProducto.Text = total.ToString();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["producto"].Value.ToString().Equals(cboProducto.Text))
                {
                    MessageBox.Show("PRODUCTO: " + cboProducto.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un PRODUCTO!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboVendedor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un VENDEDOR!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un VENDEDOR!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboEntrega.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una FORMA DE ENTREGA!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una FORMA DE PAGO!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboPedido.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una FORMA DE PEDIDO!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Producto p = (Producto)cboProducto.SelectedItem;
            int cantidad = Convert.ToInt32(nudCantidad.Text);
            DetalleFactura detalle = new DetalleFactura(cantidad, p);
            nueva.agregarDetalle(detalle);
            dgvDetalles.Rows.Add(new object[] { p.IdProducto, p.Descripcion, p.Precio, nudCantidad.Text });
            CalcularTotal();
            totalProductos();
            btnAceptar.Enabled = true;
            
        }

        private void dgvDetalles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Desea eliminar este producto?", "ELIMINAR", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                nueva.quitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                totalProductos();
                CalcularTotal();
                if (dgvDetalles.Rows.Count > 0)
                {
                    btnAceptar.Enabled = true;
                }
                if(dgvDetalles.Rows.Count <= 0)
                {
                    btnAceptar.Enabled=false;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            await GuardarFacturaAsync();
        }

        private async void AltaFactura_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            proximaFactura();
            await ComboVendedor();
            await comboCliente();
            await comboFormaEntrega();
            await comboMedioPedido();
            await comboFormaPago();
            await comboProducto();
            limpiarCampos();
        }
    }
}
