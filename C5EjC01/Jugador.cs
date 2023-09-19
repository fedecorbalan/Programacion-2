using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5EjC01
{
    internal class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            if (partidosJugados != 0)
            {
                promedioGoles = totalGoles / partidosJugados;
            }
            return promedioGoles;
        }

        private Jugador()
        {
            this.dni = 0;
            this.nombre = string.Empty;
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\n Nombre: {this.nombre}");
            sb.Append($"\n Dni: {this.dni}");
            sb.Append($"\n Partidos Jugados: {this.partidosJugados}");
            sb.Append($"\n Promedio Goles: {this.GetPromedioGoles()}");
            sb.Append($"\n Total Goles: {this.totalGoles}");

            return sb.ToString();
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.dni != jugador2.dni;
        }

        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.dni == jugador2.dni;
        }
    }
}
