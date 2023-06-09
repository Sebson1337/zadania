using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double bmi, w, h, s;

        Console.WriteLine("obliczanie bmi, podaj swoja wage");
        w = inputValue();
        Console.WriteLine("teraz podaj swoj wzrost (np. 1,75)");
        h = inputValue();
        s = w / 2 * h;
        bmi = s / 2;
        Console.WriteLine("twoje bmi wynosi"+bmi);
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

