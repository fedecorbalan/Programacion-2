using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Validador
    {
        public static bool Validar(int valor,int min,int max) 
        {
            
            if (valor < min || valor > max)
            {
                Console.WriteLine("Error, numero no valido");
                return false;
            }
            else
            {
                return true;
            }

        }

        public static int Promedio(int acumulador, int cantidad)
        {
            int resultado = acumulador / cantidad;
            return resultado;   
        }
    }
}
