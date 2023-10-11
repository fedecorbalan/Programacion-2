using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public abstract class Tren
    {
        protected int cantMaxPasajeros;
        protected string destino;
        protected bool motorEncendido;

        public abstract List<Pasajero> Pasajeros { get;}

        public Tren(int cantMaxPasajeros,string destino)
        {
            this.cantMaxPasajeros = cantMaxPasajeros;
            this.destino = destino;
        }

        public static bool operator ==(Pasajero a, Tren b)
        {
            bool retorno = false;
            
            //en esta forma debe estar sobrecargado el equals
            //return b.Pasajeros.Contains(a);

            foreach (Pasajero item in b.Pasajeros)
            {
                if (item == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Pasajero a, Tren b) 
        { 
            return !(a == b);
        }

        public static Tren operator +(Tren t, Pasajero p)
        {
            if (t.Pasajeros.Count() < t.cantMaxPasajeros)
            {
                if (p != t)
                {
                    t.Pasajeros.Add(p);
                }
                else
                {
                    Console.WriteLine("El pasajero ya esta en el tren");
                }
            }
            else
            {
                Console.WriteLine("El tren esta completo");
            }
            return t;
        }

        public virtual string IndicarDestino()
        {
            return this.destino;
        }

        public bool EncenderMotor()
        {
            this.motorEncendido = true;
            return this.motorEncendido;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.cantMaxPasajeros}-{this.destino}-{this.motorEncendido}");

            return sb.ToString();
        }

    }
}
