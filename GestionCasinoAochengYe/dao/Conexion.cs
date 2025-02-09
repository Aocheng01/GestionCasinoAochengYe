using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCasinoAochengYe.dao
{
    internal class Conexion
    {
        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "bbddaocheng.cz36at4s5jqb.us-east-1.rds.amazonaws.com";
        static string db = "casinoDI";
        static string usuario = "admin";
        static string password = "N3P75HHCvi4RBnsZyqrt";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario
            + "; password=" + password + "; database=" + db + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                //MessageBox.Show("Se conectó a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, error: " + ex.ToString());
            }
            return conexion;
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }
    }
}
