internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un ano de inicio: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un ano de fin: ");
        int final = int.Parse(Console.ReadLine());

        Console.WriteLine("Anos bisiestos en el rango: ");

        for (int ano = inicio; ano <= final; ano++)
        {
            if (EsBisiesto(ano))
            {
                Console.WriteLine(ano);
            }
        }


        static bool EsBisiesto(int ano)
        {
            if ((ano % 4 == 0 && ano % 100 != 0) ||(ano % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}