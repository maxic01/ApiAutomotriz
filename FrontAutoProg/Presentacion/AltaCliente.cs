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
    public partial class AltaCliente : Form
    {
        private IServicio servicio;
        private Cliente nuevo;
        private static AltaCliente instancia = null;
        public static AltaCliente obtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new AltaCliente();
            }
            return instancia;
        }
        public AltaCliente()
        {
            InitializeComponent();
            servicio = new ImplementacionFactory().crearServicio();
            nuevo = new Cliente();
        }

        private async Task comboBarrio()
        {
            string url = "http://localhost:5198/Barrios";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Barrios>>(data);
            cboBarrio.DataSource = lst;
            cboBarrio.DisplayMember = "Nombre";
            cboBarrio.ValueMember = "IdBarrio";
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task comboTipoCliente()
        {
            string url = "http://localhost:5198/TipoCliente";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoCliente>>(data);
            cboTipoCliente.DataSource = lst;
            cboTipoCliente.DisplayMember = "Nombre";
            cboTipoCliente.ValueMember = "IdTipoCliente";
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task ComboTipoDoc()
        {
            string url = "http://localhost:5198/TipoDoc";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoDoc>>(data);
            cboTipoDoc.DataSource = lst;
            cboTipoDoc.DisplayMember = "Tipo";
            cboTipoDoc.ValueMember = "IdTipoDoc";
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task GuardarClienteAsync()
        {
            nuevo.Nombre = txtNombre.Text;
            nuevo.IdTipoDoc = (int)cboTipoDoc.SelectedValue;
            nuevo.Idtipo = (int)cboTipoCliente.SelectedValue;
            nuevo.IdBarrio = (int)cboBarrio.SelectedValue;
            nuevo.Telefono = Convert.ToInt32(txtTelefono.Text);
            nuevo.NroDoc = Convert.ToInt32(txtDoc.Text);
            nuevo.Calle = txtCalle.Text;
            nuevo.Altura = Convert.ToInt32(txtAltura.Text);
            nuevo.Telefono = Convert.ToInt32(txtTelefono.Text);
            string bodyContent = JsonConvert.SerializeObject(nuevo);

            string url = "http://localhost:5198/Cliente";
            var result = await ClienteSingleton.GetInstance().PostAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("Cliente registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
                Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos()
        {
            cboBarrio.SelectedIndex = -1;
            cboTipoCliente.SelectedIndex = -1;
            cboTipoDoc.SelectedIndex = -1;
            txtDoc.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtAltura.Text = string.Empty;
            txtDoc.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }

        private async void AltaCliente_Load_1(object sender, EventArgs e)
        {
            await ComboTipoDoc();
            await comboTipoCliente();
            await comboBarrio();
        }

        private async void btnAceptar_Click_1(object sender, EventArgs e)
        {
            bool valido = true;
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Barrio!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            if (cboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un nombre!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            if (txtCalle.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar una calle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            if (txtAltura.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar una altura!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtAltura.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numerico!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valido = false;
                }
            }
            if (txtDoc.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un documento!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDoc.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numerico!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valido = false;
                }
            }
            if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un telefono!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtTelefono.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Debe ingresar un valor numerico!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valido = false;
                }
            }
            if (valido== true)
            {
                await GuardarClienteAsync();
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
