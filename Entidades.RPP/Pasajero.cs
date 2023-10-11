using System.Text;

namespace Entidades.RPP
{
    public class Pasajero
    {
        public string nombre;
        public string apellido;
        public ERangos rango;

        public Pasajero()
        {
            this.nombre = "SIN NOMBRE";
            this.apellido = "SIN APELLIDO";
            this.rango = ERangos.Cliente;
        }
        public Pasajero(string apellido) :this()
        {
            this.apellido = apellido;
        }
        public Pasajero(string nombre, string apellido) :this(apellido)
        {
            this.nombre = nombre;
        }
        public Pasajero(string nombre, string apellido, ERangos rango) :this(apellido, nombre)
        {
            this.rango = rango;
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            return p1.nombre == p2.nombre && p1.apellido == p2.apellido;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Pasajero)
            {   
                retorno = this == (Pasajero)obj;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.apellido}-{this.nombre}-{this.rango}");

            return sb.ToString();
        }
    }
}