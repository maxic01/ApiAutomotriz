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
    public partial class ReporteFacturas : Form
    {
        public ReporteFacturas()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MostrarFacturas mostrarFacturas = new MostrarFacturas();
            mostrarFacturas.fecha1 = dtpDesde.Value;
            mostrarFacturas.fecha2 = dtpHasta.Value;
            mostrarFacturas.ShowDialog();
        }
    }
}
