using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Indra
{
    internal class Cliente: Persona
    {
        private List<Evento> eventosInscritos;

        public List<Evento> EventosInscritos
        {
            get { return eventosInscritos; }
            set { eventosInscritos = value; }
        }

        public Cliente(int id, string nombre, string email, string contrasena)
            : base(id, nombre, email, contrasena)
        {
            eventosInscritos = new List<Evento>();
        }

        public void Inscribirse(Evento evento)
        {
            if (!eventosInscritos.Contains(evento))
            {
                eventosInscritos.Add(evento);
                evento.Participantes.Add(this);
            }
        }

        public void CancelarInscripcion(Evento evento)
        {
            if (eventosInscritos.Contains(evento))
            {
                eventosInscritos.Remove(evento);
                evento.Participantes.Remove(this);
            }
        }
    }
}
