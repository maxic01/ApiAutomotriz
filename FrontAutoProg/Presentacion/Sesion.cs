using AutomotrizBackProg.Datos;
using AutomotrizBackProg.Dominio;
using FrontAutoProg.Presentacion;
using FrontAutoProg.Servicios;
using FrontAutoProg.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LAB_Part3.Presentacion
{
    public partial class Sesion : Form
    {
        private List<Usuario> lst_sesiones = new List<Usuario>();
        private DBHelper oHelper = DBHelper.obtenerInstancia(); //HELPER con SINGLETON
        private IServicio servicio;

        public Sesion()
        {
            InitializeComponent();
            servicio = new ImplementacionFactory().crearServicio();
        }

        #region LOAD-SESION
        private void Sesion_Load(object sender, EventArgs e)
        {
           lst_sesiones = servicio.Login();
        }
        #endregion

        #region Boton-Cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar el inicio de sesión?", "Cancelar", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes)
            {
                this.Close();
            }

            //Form
            btn_aceptar.Focus();
        }
        #endregion

        #region Boton-Aceptar
        private void btn_aceptar_Click(object sender, EventArgs e)//NO TOQUEN NADA DE ESTO
        {
            bool flag_inicio = false;

            if (txt_usuario.Text != "" && txt_contra.Text != "")
            {
                foreach (Usuario oUsuario in lst_sesiones)
                {
                    if (txt_usuario.Text == oUsuario.UsuarioLogin && txt_contra.Text == oUsuario.Contraseña)
                    {
                        flag_inicio = true;
                        break;
                    }
                    else
                    {
                        flag_inicio = false;
                    }
                }

                if(flag_inicio)
                {
                    MessageBox.Show("Inicio de Sesión exitoso!");                   
                    VentanaPrincipal ventana = new VentanaPrincipal();
                    this.Hide();
                    ventana.Show();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña ingresada son incorrectas");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario y contraseña");
            }

            //Form
            txt_usuario.Focus();
            
        }
        #endregion

        #region Ocultar o mostrar Contraseña
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_mostrar.Checked)
            {
                txt_contra.PasswordChar = '\0';
            }
            else
            {
                txt_contra.PasswordChar = '*';
            }
        }
        #endregion
    }
}
