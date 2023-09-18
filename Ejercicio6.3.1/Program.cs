using Ejercicio6._3._1;
internal class Program
{
    private static void Main(string[] args)
    {
        Creadora creadora = new Creadora();

        Creadora creadora2 = new Creadora();

        Creadora creadora3 = new Creadora();

        Creadora creadora4 = new Creadora();

        Console.WriteLine(creadora.ObtenerDiferencia() + Creadora.ObtenerCantidadObjetosCreados());
        Console.WriteLine(creadora2.ObtenerDiferencia() + Creadora.ObtenerCantidadObjetosCreados());
        Console.WriteLine(creadora3.ObtenerDiferencia() + Creadora.ObtenerCantidadObjetosCreados());
        Console.WriteLine(creadora4.ObtenerDiferencia() + Creadora.ObtenerCantidadObjetosCreados());

    }

    }