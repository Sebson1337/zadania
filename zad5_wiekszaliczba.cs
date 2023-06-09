using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("podaj a");
        a = inputValue();
        Console.WriteLine("podaj b");
        b = inputValue();
        if (a > b)
        {
            Console.WriteLine(a);
        }
        else
        {
            if (b > a)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("liczby sa rowne");
            }
        }
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
