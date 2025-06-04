using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Indra
{
    internal class Inscripcion
    {
        private Cliente cliente;
        private Evento evento;
        private DateTime fechaInscripcion;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Evento Evento
        {
            get { return evento; }
            set { evento = value; }
        }

        public DateTime FechaInscripcion
        {
            get { return fechaInscripcion; }
            set { fechaInscripcion = value; }
        }

        public Inscripcion(Cliente cliente, Evento evento)
        {
            this.cliente = cliente;
            this.evento = evento;
            this.fechaInscripcion = DateTime.Now;
        }
    }
}
