internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();  

        List<int> nrosLista = new List<int>();
        Queue<int> nrosCola = new Queue<int>();
        Stack<int> nrosPila = new Stack<int>();

        for (int i = 0;i<20;i++)
        {
            int nro = random.Next(-100,101);
            while (nro == 0)
            {
                nro = random.Next(-100, 101);
            }

            nrosCola.Enqueue(nro);
            nrosLista.Add(nro);
            nrosPila.Push(nro);
        }

        Console.WriteLine("Colección Lista:");
        MostrarColeccion(nrosLista);

        Console.WriteLine("\nColección Pila:");
        MostrarColeccion(nrosPila);

        Console.WriteLine("\nColección Cola:");
        MostrarColeccion(nrosCola);

        List<int> positivos = nrosLista.Where(n => n > 0).OrderByDescending(n => n).ToList();

        // Mostrar los positivos ordenados en forma decreciente.
        Console.WriteLine("\nPositivos ordenados en forma decreciente:");
        MostrarColeccion(positivos);

        // Filtrar y ordenar los números negativos en forma creciente.
        List<int> negativos = nrosLista.Where(n => n < 0).OrderBy(n => n).ToList();

        // Mostrar los negativos ordenados en forma creciente.
        Console.WriteLine("\nNegativos ordenados en forma creciente:");
        MostrarColeccion(negativos);

        static void MostrarColeccion(IEnumerable<int> coleccion)
        {
            foreach (var numero in coleccion)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

    }
}