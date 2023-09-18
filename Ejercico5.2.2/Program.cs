using Ejercico5._2._2;

internal class Program
{
    private static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Ingrese un numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero para poder realizar una operacion: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un caracter para realizar la operacion [+;-;*;/]: ");
            char operador = char.Parse(Console.ReadLine());

            double resultado = Calculadora.Calcular(num1, num2, operador);

            if (double.IsNaN(resultado))
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
            }
            else
            {
                Console.WriteLine($"Resultado: {resultado}");
            }

            Console.Write("¿Desea realizar otra operación? (S/N): ");
            char respuesta = char.Parse(Console.ReadLine());
            continuar = (respuesta == 'S' || respuesta == 's');

        }




    }
}