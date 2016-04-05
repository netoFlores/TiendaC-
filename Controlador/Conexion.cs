using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Controlador
{
    public class Conexion
    {
        private MySqlConnection conn = new MySqlConnection();
        private String server = "localhost";
        private String user = "root";
        private String passwd = "";
        private String db = "tienda";
        private int port = 3306;
        public Conexion()
        {
            conn.ConnectionString = String.Format("server={0}; port={1}; user={2}; password={3}; database={4}; pooling=false", server, port, user, passwd, db);

            try
            {
                conn.Open();
            }catch(Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            
        }

        public MySqlConnection Conn
        {
            get { return this.conn; }
        }
    }
}
