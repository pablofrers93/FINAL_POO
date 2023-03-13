using FinalG2022.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalG2022.Datos
{
    public class ManejadorArchivoSecuencia
    {
        public static List<Jugador> LeerDatos(string archivo)
        {
            List<Jugador> lista = new List<Jugador>();
            if (!File.Exists(archivo))
            {
                return lista;
            }

            using (var lector = new StreamReader(archivo))
            {
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Persona a = ConstruirJugador(linea);
                    lista.Add(a);
                }
            }

            return lista;
        }

        private static Jugador ConstruirJugador(string linea)
        {
            var campos = linea.Split('|');
            var nombre = campos[0];
            var apellido = campos[1];
            var fechaNac = DateTime.Parse(campos[2]);
            var dni = long.Parse(campos[3]);
            var peso = float.Parse(campos[4]);
            var altura = float.Parse(campos[6]);
            var posicion = (Posicion)int.Parse(campos[7]);

            Jugador j =new Jugador(nombre,apellido,fechaNac,dni,peso,altura,posicion)
            

            return j;
        }
        public static void Guardar(string archivo, List<Persona> lista)
        {
            using (var escritor = new StreamWriter(archivo, true))
            {
                foreach (var persona in lista)
                {
                    var linea = ConstruirLinea(persona);
                    escritor.WriteLine(linea);

                }
            }
        }

        private static string ConstruirLinea(Persona persona)
        {
            if (persona.GetType() == typeof(Jugador))
            {
                return
                    $"{persona.Nombre}|{persona.Apellido}|{((Jugador)persona).Numero}|{((Jugador)persona).EsCapitan}|{Tipo.Jugador}";
            }
            return $"{persona.Nombre}|{persona.Apellido}|{Tipo.Tecnico}";
        }

    }
}
