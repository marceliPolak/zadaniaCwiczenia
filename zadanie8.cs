/*
using System;

class Program
{
    public static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj numer operacji: ");
        Console.WriteLine("1. Dodawanie");
        Console.WriteLine("2. Odejmowanie");
        Console.WriteLine("3. Mnożenie");
        Console.WriteLine("4. Dzielenie");
        int operation = int.Parse(Console.ReadLine());

        double result;

        switch (operation)
        {
            case 1:
                result = number1 + number2;
                break;
            case 2:
                result = number1 - number2;
                break;
            case 3:
                result = number1 * number2;
                break;
            case 4:
                if (number2 == 0)
                {
                    Console.WriteLine("Nie można dzielić przez zero. Wynik: {0}/{1}", number1, number2);
                    return;
                }
                result = number1 / number2;
                break;
            default:
                Console.WriteLine("Nieprawidłowy numer działania.");
                return;
        }

        Console.WriteLine("Wynik: " + result);
    }
}
*/