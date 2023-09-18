using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class ejercicio4
    {
        static void Main()
        {
            int numero = 4; // Número de números perfectos que deseas encontrar
            int contador = 0; // Contador de números perfectos encontrados
            int numAVerificar = 1; // Posible número perfecto a verificar

            Console.WriteLine($"Los primeros {numero} números perfectos son:");

            while (contador < numero)
            {
                if (EsNumeroPerfecto(numAVerificar))
                {
                    Console.WriteLine(numAVerificar);
                    contador++;
                }
                numAVerificar++;
            }
        }

        static bool EsNumeroPerfecto(int num)
        {
            int sumaDivisores = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sumaDivisores += i;
                }
            }
            return sumaDivisores == num;
        }
    }

}
