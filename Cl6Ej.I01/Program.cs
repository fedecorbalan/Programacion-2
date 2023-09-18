
internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        int[] nros = new int[20];

        for (int i = 0; i < nros.Length; i++)
        {
            nros[i] = random.Next(-100, 101); // Genera números entre -100 y 100.
            while (nros[i] == 0)
            {
                nros[i] = random.Next(-100, 101); // Vuelve a generar si es cero.
            }
        }

        Console.WriteLine("Vector original:");
        MostrarVector(nros);

        static void MostrarVector(int[] vector)
        {
            foreach (var numero in vector)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        int[] positivos = Array.FindAll(nros, n => n > 0);
        Array.Sort(positivos);
        Array.Reverse(positivos);

        // Mostrar los positivos ordenados en forma decreciente.
        Console.WriteLine("\nPositivos ordenados en forma decreciente:");
        MostrarVector(positivos);

        // Filtrar y ordenar los números negativos en forma creciente.
        int[] negativos = Array.FindAll(nros, n => n < 0);
        Array.Sort(negativos);

        // Mostrar los negativos ordenados en forma creciente.
        Console.WriteLine("\nNegativos ordenados en forma creciente:");
        MostrarVector(negativos);
    }
}