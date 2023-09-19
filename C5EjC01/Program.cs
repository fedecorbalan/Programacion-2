using C5EjC01;

internal class Program
{
    private static void Main(string[] args)
    {
        Equipo equipo = new Equipo(5, "Lentejas");

        Jugador jugador1 = new Jugador(123,"Jugador1",10,34);
        Jugador jugador2 = new Jugador(123, "Jugador2",2,1);
        Jugador jugador3 = new Jugador(123, "Jugador3",100,123);
        Jugador jugador4 = new Jugador(123, "Jugador4",123,199);
        Jugador jugador5 = new Jugador(142,"Jugador5",1,920);
        Jugador jugador6 = new Jugador(234,"Jugador6",12,2);

        equipo = equipo + jugador1; // Agregar jugador al equipo
        equipo = equipo + jugador2;
        equipo = equipo + jugador3;
        equipo = equipo + jugador4;
        equipo = equipo + jugador5;


        Console.ReadKey();
    }
}