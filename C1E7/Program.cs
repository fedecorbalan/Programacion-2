internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su fecha de nacimiento dd/mm/aaaa: ");
        string fechaNacimientoStr = Console.ReadLine();
        
        DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoStr, "dd/MM/yyyy", null);

        DateTime fechaActual = DateTime.Now;

        int diasVividos = CalcularDiasVividos(fechaNacimiento, fechaActual);

        Console.WriteLine($"Ha vivido {diasVividos} días hasta la fecha actual.");
        Console.ReadLine();

        static bool EsBisiesto(int ano)
        {
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int CalcularDiasVividos(DateTime fechaNacimiento, DateTime fechaActual)
        {
            int diasVividos = 0;

            for (int año = fechaNacimiento.Year; año <= fechaActual.Year; año++)
            {
            int diasEnAño = EsBisiesto(año) ? 366 : 365;

            // Si es el año de nacimiento, restar los días transcurridos desde la fecha de nacimiento
                if (año == fechaNacimiento.Year)
                {
                    diasVividos += diasEnAño - fechaNacimiento.DayOfYear;
                }
                // Si es el año actual, sumar los días transcurridos hasta la fecha actual
                else if (año == fechaActual.Year)
                {
                    diasVividos += fechaActual.DayOfYear;
                }
                // Para otros años en el medio, sumar todos los días del año
                else
                {
                    diasVividos += diasEnAño;
                }
            }

        return diasVividos;
        }









    }
}