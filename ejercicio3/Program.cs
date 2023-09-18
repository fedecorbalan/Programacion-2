internal class Program
{
    private static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero: ");
        int ingreso = int.Parse(Console.ReadLine());

        Console.WriteLine("Numeros primos hasta {0}",ingreso);

        for (int i = 2; i <= ingreso;i++)
        {
            if (EsPrimo(i))
            {
                Console.WriteLine(i);
            }

        }

    }
}