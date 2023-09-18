using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._3._3
{
    internal class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private double dni;

        public Persona(string nombre, DateTime fechaNacimiento, double dni) 
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        { 
            return nombre; 
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public double GetDni()
        {
            return dni;
        }

        public void SetDni(double dni)
        {
            this.dni = dni;
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }
        //no terminado, falta el main y algunos metodos.








    }
}
