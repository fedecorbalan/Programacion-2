using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected int cantAsientos;
        public Auto(string patente, byte cantRuedas, Emarcas marca, int cantAsientos) : base(patente, cantRuedas, marca)
        {
            this.cantAsientos = cantAsientos;
        }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"cantidad de asientos: {this.cantAsientos}");

            return sb.ToString();
        }
    }
}
