using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero para obtener su tabla de multiplicación: ");
        int numero = int.Parse(Console.ReadLine());

        string tablaMultiplicacion = GenerarTablaMultiplicacion(numero);

        Console.WriteLine($"Tabla de multiplicación de {numero}:\n{tablaMultiplicacion}");
    }

    static string GenerarTablaMultiplicacion(int numero)
    {
        if (numero < 1)
        {
            throw new ArgumentException("El número debe ser un entero positivo.");
        }

        StringBuilder resultado = new StringBuilder();

        for (int i = 1; i <= 20; i++)
        {
            int producto = numero * i;
            resultado.AppendLine($"{numero} x {i} = {producto}");
        }

        return resultado.ToString();
    }
}
