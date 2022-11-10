using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBackProg.Dominio
{
    public class Usuario
    {
        public string UsuarioLogin { get; set; }
        public string Contraseña { get; set; }
        public Usuario(string usuario, string contrasenia)
        {
            UsuarioLogin = usuario;
            Contraseña = contrasenia;
        }
    }
}
