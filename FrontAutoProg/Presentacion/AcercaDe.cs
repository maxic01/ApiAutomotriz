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
    public partial class AcercaDe : Form
    {
        private static AcercaDe instancia;
        public AcercaDe()
        {
            InitializeComponent();
        }

        public static AcercaDe Instancia()
        {
            if(instancia == null)
                instancia = new AcercaDe();
            return instancia;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
