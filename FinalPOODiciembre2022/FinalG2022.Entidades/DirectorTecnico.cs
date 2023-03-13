using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalG2022.Entidades
{
    public class DirectorTecnico : Persona
    {
        public int AniosExperiencia { get; set; }

        public DirectorTecnico(string apellido, int dni, DateTime fechaNac, string nombre, int aniosExp) : base(apellido, dni, fechaNac, nombre)
        {
            AniosExperiencia = aniosExp;
        }

        public override bool ValidarAptitud()
        {
            return ((this.GetEdad() >= 45 && this.GetEdad() <= 60) &&
                    (this.AniosExperiencia >= 2));
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Años de experiencia: ".PadLeft(20) + $"{this.AniosExperiencia}");

            return sb.ToString();
        }
    }
}
