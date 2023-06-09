using System;


public class MyProgram1
{
    public static void Main(string[] args)
    {
        double a, b, c, d;

        Console.WriteLine("Obliczanie sredniej arytmetycznej, podaj pierwszą liczbe");
        a = inputValue();
        Console.WriteLine("podaj druga liczbe");
        b = inputValue();
        Console.WriteLine("podaj trzecia liczbe");
        c = inputValue();
        d = a * b * c / 3;
        Console.WriteLine(d);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

