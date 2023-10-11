using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioMoto = precioMoto;
            this.precioCamion = precioCamion;
        }

        public string Detalle
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Precios: Auto: {precioAuto}");
                sb.AppendLine($"Camión: {precioCamion}");
                sb.AppendLine($"Moto: {precioMoto}");
                sb.AppendLine($"Vehículos:");

                foreach (var vehiculo in Vehiculos)
                {
                    sb.AppendLine(vehiculo.ToString());
                }
                return sb.ToString();
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return this.vehiculos;
            }
        }

        public double MostrarTotalFacturado()
        {
            double total = 0;

            foreach (Vehiculo v in vehiculos)
            {
                if (v is Auto)
                {
                    total += precioAuto;
                }
                else if (v is Moto)
                {
                    total += precioMoto;
                }
                else if (v is Camion)
                {
                    total += precioCamion;
                }

            }
            return total;
        }


        public double MostrarTotalFacturado(Evehiculos tipoVehiculo)
        {
            double total = 0;
            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo is Auto && tipoVehiculo == Evehiculos.Auto)
                {
                    total += precioAuto;
                }
                else if (vehiculo is Camion && tipoVehiculo == Evehiculos.Camion)
                {
                    total += precioCamion;
                }
                else if (vehiculo is Moto && tipoVehiculo == Evehiculos.Moto)
                {
                    total += precioMoto;
                }
            }
            return total;
        }
        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            return lavadero.vehiculos.Contains(vehiculo);
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
            {
                lavadero.vehiculos.Add(vehiculo);
            }
            return lavadero;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
            {
                lavadero.vehiculos.Remove(vehiculo);
            }
            return lavadero;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            if (int.Parse(v1.Patente) == int.Parse(v2.Patente))
            {
                return 0;
            }
            else if(int.Parse(v1.Patente) > int.Parse(v2.Patente))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        
        public int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            //familia.Sort(Program.OrdenarPorEntero);
            if (v1.Marcas == v2.Marcas)
            { 
                return 0; 
            }
            else if(v1.Marcas > v2.Marcas)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }







      
    }
}