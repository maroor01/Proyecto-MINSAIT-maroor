using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Indra
{
    internal class Persona
    {
        protected int id;
        protected string nombre;
        protected string email;
        protected string contrasena;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public Persona(int id, string nombre, string email, string contrasena)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.contrasena = contrasena;
        }
    }
}
