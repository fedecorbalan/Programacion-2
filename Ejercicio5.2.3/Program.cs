using Ejercicio5._2._3;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero para sacar su factorial");
        int numero = int.Parse(Console.ReadLine());

        long factorial = CalcularFactorial.Factorializar(numero);

        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }
}