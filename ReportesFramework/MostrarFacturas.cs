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
    public partial class MostrarFacturas : Form
    {
        public MostrarFacturas()
        {
            InitializeComponent();
        }

        public DateTime fecha1;
        public DateTime fecha2;
        private void MostrarFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_PROGDataSet1.reporteFacturas' Puede moverla o quitarla según sea necesario.
            this.reporteFacturasTableAdapter.Fill(this.bD_PROGDataSet1.reporteFacturas, fecha1, fecha2);

            this.reportViewer1.RefreshReport();
        }
    }
}
