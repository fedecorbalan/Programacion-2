using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6._3._2
{
    internal class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string ObtenerNombreTitular()
        {
            return titular;
        }
        public decimal ObtenerCantidad()
        {
            return cantidad;
        }
        public string Mostrar()
        {
            return $"Titular: {titular}, Saldo: {cantidad:C}";
        }

        public void ingresar(decimal monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }
        public void retirar(decimal monto)
        {
            if (monto > 0)
            {
                cantidad -= monto;
            }
        }

    }
}
