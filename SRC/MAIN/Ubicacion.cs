using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Indra
{
    internal class Ubicacion
    {
        private int id;
        private string tipo;
        private string direccion;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Ubicacion(int id, string tipo, string direccion)
        {
            this.id = id;
            this.tipo = tipo;
            this.direccion = direccion;
        }
    }
}
