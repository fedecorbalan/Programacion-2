internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio 1";
        int maximo = 0;
        int minimo = 0;
        int acumulador = 0;
        int cantidad_numeros = 5;
        
        

        for (int i = 0; i < cantidad_numeros; i++) { 

        Console.WriteLine("Ingrese un numero {0}/5: ",i);
        int numero = int.Parse(Console.ReadLine());

        acumulador += numero;

        if (maximo <= numero)
        {
            maximo = numero;
        }
        
        if (minimo > numero) 
        { 
            minimo = numero;
        }
        
        }
        double promedio = (double)acumulador / cantidad_numeros;



        Console.WriteLine("El valor maximo es {0}, el minimo es {1} y el promedio de todos los numeros es {2}",maximo, minimo, promedio);
        Console.ReadLine();
    }
}