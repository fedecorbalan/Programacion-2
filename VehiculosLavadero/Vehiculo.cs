using System.Text;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Vehiculo
    {
        protected string patente;
        protected byte cantRuedas;
        protected Emarcas marca;

        public string Patente { get { return patente; } }

        public Emarcas Marcas
        {
            get { return this.marca; }
        }
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.patente}");
            sb.AppendLine($"Cantidad de Ruedas: {this.cantRuedas}");
            sb.AppendLine($"Marca: {this.marca.ToString()}");

            return sb.ToString();
        }

        public Vehiculo(string patente, byte cantRuedas, Emarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.patente == v2.patente && v1.marca == v2.marca ;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2) 
        { 
            return !(v1 == v2); 
        }
        public override bool Equals(object obj)
        {
            if (obj is Vehiculo vehiculo)
            {
                return this == vehiculo;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.patente.GetHashCode() ^ this.marca.GetHashCode();
        }
    }
}