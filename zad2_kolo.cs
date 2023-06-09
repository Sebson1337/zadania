using System;

public class MyProgram
{
    public static void Main(string[] args)
      
    {
        
    double r, p, o;
    double d = Math.PI;

    Console.WriteLine("podaj r koła:");
        r = inputValue();
        p = d * r * r;
        o = 2 * d * r;
        Console.WriteLine("obwod kola wynosi "+o);
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
