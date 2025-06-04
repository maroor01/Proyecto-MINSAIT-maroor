using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Indra
{
    internal class Evento
    {
        private int id;
        private string nombre;
        private DateTime fecha;
        private int duracionHoras;
        private Ubicacion ubicacion;
        private Categoria categoria;
        private Administrador organizador;
        private List<Cliente> participantes;
        private bool cancelado;

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

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int DuracionHoras
        {
            get { return duracionHoras; }
            set { duracionHoras = value; }
        }

        public Ubicacion Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public Administrador Organizador
        {
            get { return organizador; }
            set { organizador = value; }
        }

        public List<Cliente> Participantes
        {
            get { return participantes; }
            set { participantes = value; }
        }

        public bool Cancelado
        {
            get { return cancelado; }
        }

        public Evento(int id, string nombre, DateTime fecha, int duracion, Ubicacion ubicacion, Categoria categoria, Administrador organizador)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha = fecha;
            this.duracionHoras = duracion;
            this.ubicacion = ubicacion;
            this.categoria = categoria;
            this.organizador = organizador;
            this.participantes = new List<Cliente>();
            this.cancelado = false;
        }

        public void CancelarEvento()
        {
            cancelado = true;
        }
    }
}
