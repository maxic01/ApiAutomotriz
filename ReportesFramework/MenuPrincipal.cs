using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportesFramework
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void reporteProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteFacturas facturas = new ReporteFacturas();
            facturas.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteProductos productos = new ReporteProductos();
            productos.ShowDialog();
        }
    }
}
