using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 0)
        {
            Console.WriteLine("Error.¡Reingresar número!");

        }
        else
        {
            double numeroCuadrado = Math.Pow(numero, 2);
            double numeroCubo = Math.Pow(numero, 3);
            Console.WriteLine("Se ha ingresado el numero {0}, que al cuadrado es {1} y al cubo {2}", numero, numeroCuadrado,numeroCubo);
        }
        
    }
}