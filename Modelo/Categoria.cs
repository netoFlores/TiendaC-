using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        private int idCategoria;
        private String nombre, descripcion;
        private DateTime fecha_reacion, fecha_mod;
        public Categoria()
        {

        }

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public DateTime Fecha_reacion
        {
            get
            {
                return fecha_reacion;
            }

            set
            {
                fecha_reacion = value;
            }
        }

        public DateTime Fecha_mod
        {
            get
            {
                return fecha_mod;
            }

            set
            {
                fecha_mod = value;
            }
        }

      

    }
}
