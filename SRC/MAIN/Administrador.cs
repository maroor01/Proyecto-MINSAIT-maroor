using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Indra
{
    internal class Administrador: Persona
    {
        private List<Evento> eventosCreados;

        public List<Evento> EventosCreados
        {
            get { return eventosCreados; }
            set { eventosCreados = value; }
        }

        public Administrador(int id, string nombre, string email, string contrasena)
            : base(id, nombre, email, contrasena)
        {
            eventosCreados = new List<Evento>();
        }

        public Evento CrearEvento(int id, string nombre, DateTime fecha, int duracion, Ubicacion ubicacion, Categoria categoria)
        {
            Evento nuevoEvento = new Evento(id, nombre, fecha, duracion, ubicacion, categoria, this);
            eventosCreados.Add(nuevoEvento);
            return nuevoEvento;
        }

        public void CancelarEvento(Evento evento)
        {
            if (eventosCreados.Contains(evento))
            {
                evento.CancelarEvento();
            }
        }
    }
}
