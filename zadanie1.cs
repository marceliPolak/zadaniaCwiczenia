
using System;

class Program
{
    public static void Main()
    {
        double a, b, c;
        Console.Write("Podaj 1 liczbę: ");
        a = Double.Parse(Console.ReadLine());
        Console.Write("Podaj 2 liczbę: ");
        b = Double.Parse(Console.ReadLine());
        Console.Write("Podaj 3 liczbę: ");
        c = Double.Parse(Console.ReadLine());
        double średniaArytmetyczna;

        średniaArytmetyczna = (a + b + c) / 3;
        Console.WriteLine("Średnia arytmetyczna tych liczb to: " + średniaArytmetyczna);
    }


}
