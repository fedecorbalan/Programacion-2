using Ejercicio6._3._2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del/la titular de la cuenta: ");
        string titular = Console.ReadLine();

        Console.WriteLine("Ingrese el monto inicial de la cuenta: ");
        decimal cantidad = decimal.Parse(Console.ReadLine()); 

        Cuenta cuentaNueva = new Cuenta(titular,cantidad);

        bool continuar = true;

        while (continuar)
        {

            Console.WriteLine("Datos de la cuenta:");
            Console.WriteLine(cuentaNueva.Mostrar());

            Console.WriteLine("Desea ingresar o retirar dinero [I/R]: ");
            char metodo = char.Parse(Console.ReadLine());

            if (metodo == 'I' || metodo == 'i')
            {
                Console.WriteLine("Cuanto dinero desea ingresar: ");
                decimal ingreso = decimal.Parse(Console.ReadLine());    

                cuentaNueva.ingresar(ingreso);
                Console.WriteLine($"Nuevo saldo: {cuentaNueva.ObtenerCantidad():C}");
            }
            else if (metodo == 'R'|| metodo == 'r')
            {
                Console.WriteLine("Cuanto dinero desea retirar: ");
                decimal retiro = decimal.Parse(Console.ReadLine());

                cuentaNueva.retirar(retiro);
                Console.WriteLine($"Nuevo saldo: {cuentaNueva.ObtenerCantidad():C}");
            }

            Console.Write("¿Desea realizar otra operación? (S/N): ");
            char respuesta = char.Parse(Console.ReadLine());
            continuar = (respuesta == 'S' || respuesta == 's');
        }
    }
}