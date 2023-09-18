using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico5._2._2
{
    internal class Calculadora
    {
        public static int Calcular(double num1, double num2, char operador)
        {
            double resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    if (num2 != 0) 
                    {
                       resultado = num1 / num2;
                    }
                    else
                    {
                        resultado = double.NaN;
                    }    
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
            }
            return (int)resultado;
            
        }
    }
}
