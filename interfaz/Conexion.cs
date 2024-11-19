using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaz
{
    public class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "sistemacheys";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id=" + user +
                "; Password=" + password;

        }
        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion;
        }
    }
}
