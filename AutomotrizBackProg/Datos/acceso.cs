using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutomotrizBackProg.Datos
{
    public class acceso
    {
        protected SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-U2NBR94\SQLEXPRESS;Initial Catalog=BD_PROG;Integrated Security=True");
        protected SqlCommand comando = new SqlCommand();
        protected void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        protected void desconectar()
        {
            conexion.Close();
        }
    }
}
