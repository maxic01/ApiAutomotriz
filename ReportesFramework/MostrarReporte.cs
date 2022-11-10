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

namespace ReportesFramework
{
    public partial class MostrarReporte : Form
    {
        public MostrarReporte()
        {
            InitializeComponent();
        }

        public string Nombre;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_PROGDataSet.reporteProductos' Puede moverla o quitarla según sea necesario.
            this.reporteProductosTableAdapter.Fill(this.bD_PROGDataSet.reporteProductos, Nombre);

            this.reportViewer1.RefreshReport();
        }
    }
}
