
using ejercicio4;
using System.Text;

internal class Program
    
{
    private static void Main(string[] args)
    {
        int acumulador = 0;
        int cantidadNumeros = 10;
        int max = 0;
        int min = 0;


        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.WriteLine("Ingrese 10 numeros");
            int numero = int.Parse(Console.ReadLine());

            bool validacion = Validador.Validar(numero, -100, 100);
            if (validacion == true)
            {
                if (numero > max)
                {
                    max = numero;
                }
                if (numero < min || min == 0)
                {
                    min = numero;
                }
                acumulador += numero;
            }
            else
            {
                i--;
            }

        }
        int promedio = Validador.Promedio(acumulador, cantidadNumeros);
        Console.WriteLine("El Maximo ingresado es {0}, el minimo {1} y el promedio de todos los numeros es de {2}",max,min,promedio);

    }  
}