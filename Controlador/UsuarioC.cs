using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Windows.Forms;
namespace Controlador
{
    public class UsuarioC
    {
        private Conexion conn;
        private MySqlCommand cmd;
        private MySqlDataReader dr;
        
        public UsuarioC(Conexion conn)
        {
            try
            {
                this.conn = conn;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);              
            }
        }

        public void insert(Usuario usuario)
        {
            try
            {
                cmd = conn.Conn.CreateCommand();
                cmd.CommandText = "INSERT INTO usuario(nombre, apellido, direccion, telefono, email, clave, usuario) VALUES(?nombre, ?apellido, ?direccion, ?telefono, ?email, ?clave, ?usuario)";
                cmd.Parameters.Add("?nombre", usuario.Nombre);
                cmd.Parameters.Add("?apellido", usuario.Apellido);
                cmd.Parameters.Add("?direccion", usuario.Direccion);
                cmd.Parameters.Add("?telefono", usuario.Telefono);
                cmd.Parameters.Add("?email", usuario.Telefono);
                cmd.Parameters.Add("?clave", usuario.Clave);
                cmd.Parameters.Add("?usuario", usuario.Ussuario);
                cmd.ExecuteNonQuery();
                conn.Conn.Close();

            }
            catch (MySqlException e)
            {

                throw;
            }
        }

        public void update(Usuario usuario)
        {
            try
            {
                cmd = conn.Conn.CreateCommand();
                cmd.CommandText = "UPDATE usuario SET nombre = ?nombre, apellido = ?apellido, direccion = ?direccion, telefono = ?telefono WHERE idUsuario = ?idUsuario";
                cmd.Parameters.Add("?nombre", usuario.Nombre);
                cmd.Parameters.Add("?apellido", usuario.Apellido);
                cmd.Parameters.Add("?direccion", usuario.Direccion);
                cmd.Parameters.Add("?telefono", usuario.Telefono);
                cmd.Parameters.Add("?idUsuario", usuario.IdUsuario);
                cmd.ExecuteNonQuery();
                conn.Conn.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void delete(Usuario usuario)
        {
            try
            {
                cmd = conn.Conn.CreateCommand();
                cmd.CommandText = "DELETE FROM usuario WHERE idUsuario = ?idUsuario";
                cmd.Parameters.Add("?idUsuario", usuario.IdUsuario);
                cmd.ExecuteNonQuery();
                conn.Conn.Close();
            }
            catch (MySqlException e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public List<Usuario> findAll()
        {
            List<Usuario> dt = new List<Usuario>();
            try
            {
                cmd = conn.Conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM usuario";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = int.Parse(dr["idUsuario"] + "");
                    usuario.Nombre = dr["nombre"] + "";
                    usuario.Apellido = dr["apellido"] + "";
                    usuario.Direccion = dr["direccion"] + "";
                    usuario.Email = dr["email"] + "";
                    usuario.Clave = dr["clave"] + "";
                    usuario.Ussuario = dr["usuario"] + "";
                    usuario.Fecha_creacion = DateTime.Parse( dr["fecha_creacion"] + "");
                    usuario.Fecha_mod = DateTime.Parse(dr["fecha_mod"] + "");
                    dt.Add(usuario);
                }
            }
            catch (MySqlException e)
            {

                MessageBox.Show(e.Message);
            }
            return dt;
        }

    }
}
