using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5._2._3
{
    internal class CalcularFactorial
    {
        public static long Factorializar(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("El número debe ser un entero no negativo.");
            }

            if (numero == 0 || numero == 1)
            {
                return 1;
            }
            else
            {
                long resultado = 1;

                for (int i = 2; i <= numero; i++)
                {
                    resultado *= i;
                }

                return resultado;
            }
        }
    }
}
