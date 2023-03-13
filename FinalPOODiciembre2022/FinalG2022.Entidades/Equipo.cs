using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalG2022.Entidades
{
    public class Equipo
    {
        static int cantidadMaximaJugadores = 6;
        private List<Jugador> jugadores;

        public string Nombre { get; set; }
        public DirectorTecnico DirectorTecnico { get; set; }
                   

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, DirectorTecnico dt):this()
        {
            Nombre = nombre;
            DirectorTecnico = dt;
            jugadores = new List<Jugador>();
        }

        public static explicit operator String(Equipo equipo)
        {
            StringBuilder sb = new StringBuilder();

            if (equipo.DirectorTecnico != null)
            {
                sb.AppendLine($"Director Técnico: ".PadLeft(20) + $"{equipo.DirectorTecnico}");
            }
            else
                sb.AppendLine($"Director Técnico: ".PadLeft(20) + $"Sin DT Asignado");

            
            sb.AppendLine(equipo.MostrarJugadores(equipo));

            return sb.ToString();
        }

        private string MostrarJugadores(Equipo equipo)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var jugador in equipo.jugadores)
            {
                sb.AppendLine($"Jugador: {jugador.Apellido}, {jugador.Nombre}");
            }

            return sb.ToString();
        }
        public static bool operator ==(Equipo e1, Jugador j1)
        {
            return e1.jugadores.Contains(j1);
        }
        public static bool operator !=(Equipo e1, Jugador j1)
        {
            return !e1.jugadores.Contains(j1);
        }
        public static Equipo operator +(Equipo e1, Jugador j1)
        {
            if ((e1 != j1) && (e1.jugadores.Count() < cantidadMaximaJugadores) && j1.ValidarAptitud())
            {
                e1.jugadores.Add(j1);
                return e1;
            }
            else
                return e1;
        }

        public static bool ValidarEquipo(Equipo equipo)
        {
            return (equipo.DirectorTecnico != null &&
                   equipo.jugadores.Count() == cantidadMaximaJugadores);
        }

    }
}
