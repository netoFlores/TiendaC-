using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;
using MySql.Data.MySqlClient;
namespace TiendaIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
            Usuario u = new Usuario();
            u.Nombre = "jmm";
            u.Apellido = "mm";
            u.Direccion = "dd";
            u.Email = "dw";
            u.Clave = "cc";
            u.Telefono = "99999";
            u.Ussuario = "mmdd";

            try
            {
                UsuarioC uc = new UsuarioC(conn);
                uc.insert(u);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
           

            try
            {
                UsuarioC uc = new UsuarioC(conn);
                List<Usuario> listado = uc.findAll();
                foreach(Usuario u in listado)
                {
                    MessageBox.Show(u.Fecha_creacion.ToString());

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
