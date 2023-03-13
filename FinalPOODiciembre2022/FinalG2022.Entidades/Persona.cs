using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalG2022.Entidades
{
    public abstract class Persona
    {
        public string Apellido { get; set; }
        public int Dni { get; set; }
        private DateTime fechaNacimiento;
        public string Nombre { get; set; }

        public Persona(string apellido, int dni, DateTime fechaNac, string nombre)
        {
            Apellido = apellido;
            Dni = dni;
            fechaNacimiento = fechaNac;
            Nombre = nombre;
        }
        public int GetEdad()
        {
            return DateTime.Now.Year - fechaNacimiento.Year;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Apellido:".PadLeft(20) + $"{this.Apellido}");
            sb.AppendLine("Nombre:".PadLeft(20) + $"{this.Nombre}");
            sb.AppendLine("Dni:".PadLeft(20) + $"{this.Dni}");
            sb.AppendLine("Fecha de Nacimiento:".PadLeft(20) + $"{this.fechaNacimiento}");

            return sb.ToString();
        }
        public abstract bool ValidarAptitud();




    }
}
