using ReportesFramework;
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
    public partial class ReporteAuto : Form
    {
        public ReporteAuto()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarReporte frm = new MostrarReporte();
            frm.ShowDialog();
        }
    }
}
