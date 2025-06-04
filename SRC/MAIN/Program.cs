using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Indra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear categorías
            Categoria categoriaTaller = new Categoria(1, "Taller");
            Categoria categoriaConferencia = new Categoria(2, "Conferencia");

            // Crear ubicaciones
            Ubicacion ubicacionPresencial = new Ubicacion(1, "Presencial", "Aula 101 - Campus Verde");
            Ubicacion ubicacionOnline = new Ubicacion(2, "Online", "https://eventosostenible.com/sala");

            // Crear administrador
            Administrador admin = new Administrador(1, "María Eco", "maria@admin.com", "admin123");

            // El administrador crea dos eventos
            Evento evento1 = admin.CrearEvento(1, "Reciclaje Creativo", new DateTime(2025, 6, 10, 10, 0, 0), 2, ubicacionPresencial, categoriaTaller);
            Evento evento2 = admin.CrearEvento(2, "Innovación en Energías Renovables", new DateTime(2025, 6, 15, 17, 0, 0), 3, ubicacionOnline, categoriaConferencia);

            Console.WriteLine("\n[Eventos creados por el administrador]");
            foreach (Evento ev in admin.EventosCreados)
            {
                Console.WriteLine($"- {ev.Nombre} ({ev.Categoria.Nombre}) en {ev.Ubicacion.Tipo}: {ev.Ubicacion.Direccion}");
            }

            // Crear clientes
            Cliente cliente1 = new Cliente(101, "Carlos Verde", "carlos@correo.com", "verde2025");
            Cliente cliente2 = new Cliente(102, "Lucía Bosque", "lucia@correo.com", "bosque123");

            // Clientes se inscriben a eventos
            cliente1.Inscribirse(evento1);
            cliente2.Inscribirse(evento1);
            cliente1.Inscribirse(evento2); // Carlos se apunta también al evento online

            Console.WriteLine("\n[Inscripciones]");
            Console.WriteLine($"{cliente1.Nombre} está inscrito en:");
            foreach (Evento ev in cliente1.EventosInscritos)
            {
                Console.WriteLine($"- {ev.Nombre}");
            }

            Console.WriteLine($"{cliente2.Nombre} está inscrita en:");
            foreach (Evento ev in cliente2.EventosInscritos)
            {
                Console.WriteLine($"- {ev.Nombre}");
            }

            // Mostrar participantes del evento 1
            Console.WriteLine($"\n[Participantes en {evento1.Nombre}]:");
            foreach (Cliente c in evento1.Participantes)
            {
                Console.WriteLine($"- {c.Nombre}");
            }

            // Cliente cancela una inscripción
            cliente2.CancelarInscripcion(evento1);
            Console.WriteLine($"\n[Cancelación] {cliente2.Nombre} ha cancelado su inscripción en {evento1.Nombre}");

            // Mostrar participantes actualizados
            Console.WriteLine($"\n[Participantes actuales en {evento1.Nombre}]:");
            foreach (Cliente c in evento1.Participantes)
            {
                Console.WriteLine($"- {c.Nombre}");
            }

            // Administrador cancela un evento
            admin.CancelarEvento(evento2);
            Console.WriteLine($"\n[Estado del evento]");
            Console.WriteLine($"- {evento2.Nombre} cancelado: {evento2.Cancelado}");
        }
    }
}
