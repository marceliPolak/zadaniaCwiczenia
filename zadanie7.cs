/*
using System;

class Program
{
    public static void Main()
    {
        
        //Wersja z wpisywaniem przez użytkownika współrzędnych środka koła

        Console.Write("Podaj współrzędną x punktu P: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Podaj współrzędną y punktu P: ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("Podaj współrzędną x środka koła O: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj współrzędną y środka koła O: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj promień koła r:");
        double r = double.Parse(Console.ReadLine());

        bool lezyWObrebieKola = SprawdzCzyPunktLezyWKole(x, y, a, b, r);
        if (lezyWObrebieKola)
        {
            Console.WriteLine("Punkt leży w obrębie koła.");
        }
        else
        {
            Console.WriteLine("Punkt nie leży w obrębie koła.");
        }
    }

    static bool SprawdzCzyPunktLezyWKole(double x, double y, double a, double b, double r)
    {
        double odlegloscOdSrodka = Math.Pow(x - a, 2) + Math.Pow(y - b, 2);
        return odlegloscOdSrodka <= Math.Pow(r, 2);
    }
}
*/