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
    public partial class ReporteProductos : Form
    {
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarReporte mostrar = new MostrarReporte();
            mostrar.Nombre = txtProducto.Text;
            mostrar.ShowDialog();
        }
    }
}
