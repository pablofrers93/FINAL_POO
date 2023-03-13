using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalG2022.Entidades
{
    public class Jugador : Persona
    {
        public float Altura { get; }
        public float Peso { get; }
        public Posicion Posicion { get; }

        public Jugador(string apellido, int dni, DateTime fechaNac, string nombre, float altura, float peso, Posicion posicion):base(apellido, dni, fechaNac, nombre)
        {
            Altura = altura;
            Peso = peso;
            Posicion = posicion;
        }
        public override bool ValidarAptitud()
        {
            return (((this.GetEdad() >= 18) &&
                    (this.GetEdad() <= 40)) &&
                    this.ValidarEstadoFisico());
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Altura: ".PadLeft(20) + $"{this.Altura}");
            sb.AppendLine($"Peso: ".PadLeft(20) + $"{this.Peso}");
            sb.AppendLine($"Posicion: ".PadLeft(20) + $"{this.Posicion}");

            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            return ((this.Peso / Math.Pow(this.Altura, 2)) >= 18.5f) ||
                    ((this.Peso / Math.Pow(this.Altura, 2) <= 25f));
        }

        public override bool Equals(Object obj)
        {
            if (obj is Jugador)
            {
                return this.Dni == ((Jugador)obj).Dni;
            }
            else return false;
        }
    }
}
