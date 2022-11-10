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
    public partial class AltaProducto : Form
    {
        private IServicio servicio;
        private Producto nuevo;
        private static AltaProducto instancia = null;
        public static AltaProducto obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new AltaProducto();
            }
            return instancia;
        }

        public AltaProducto()
        {
            InitializeComponent();
            servicio = new ImplementacionFactory().crearServicio();
            nuevo = new Producto();
        }
        private async Task GuardarProductoAsync()
        {
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Precio = Convert.ToInt32(txtPrecio.Text);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "http://localhost:5198/Producto";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Producto registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
                Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        private void AltaProducto_Load_1(object sender, EventArgs e)
        {

        }

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            bool valido = true;
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una descripcion!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un precio!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtPrecio.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numerico!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valido=false;
                }
            }
            if(valido == true)
            {
                await GuardarProductoAsync();
            }
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
