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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void consultarFacturaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultaFactura consultaf = ConsultaFactura.obtenerInstancia();
            consultaf.Show();
            consultaf.Focus();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaFactura alta = AltaFactura.obtenerInstancia();
            alta.Show();
            alta.Focus();
        }

        private void nuevoClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AltaCliente alta = AltaCliente.obtenerInstancia();
            alta.Show();
            alta.Focus();
        }

        private void consultarClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultaClientes consultac = ConsultaClientes.obtenerInstancia();
            consultac.Show();
            consultac.Focus();
        }

        private void nuevoProductoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AltaProducto alta = AltaProducto.obtenerInstancia();
            alta.Show();
            alta.Focus();
        }

        private void consultarProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ConsultaProducto consultap = ConsultaProducto.obtenerInstancia();
            consultap.Show();
            consultap.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe Creadores = AcercaDe.Instancia();
            Creadores.Show();
        }
    }
}
