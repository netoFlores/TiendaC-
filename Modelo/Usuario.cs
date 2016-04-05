using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private int idUsuario;
        private String nombre, apellido, direccion, telefono, email, clave, usuario;
        private DateTime fecha_creacion, fecha_mod;

        public Usuario()
        {

        }

        public int IdUsuario{
            get{ return this.idUsuario; }
            set{ this.idUsuario = value; }    
        }

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public String Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public String Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public String Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        
        public String Ussuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public String Clave
        {
            get { return this.clave; }
            set { this.clave = value; }
        }

        public DateTime Fecha_creacion
        {
            get { return this.fecha_creacion; }
            set { this.fecha_creacion = value; }
        }

        public DateTime Fecha_mod
        {
            get { return this.fecha_mod; }
            set { this.fecha_mod = value; }
        }
    }
}
