using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("podaj bok trojkata a");
        a = inputValue();
        Console.WriteLine("podaj bok b");
        b = inputValue();
        Console.WriteLine("podaj bok c");
        c = inputValue();
        if (a == b)
        {
            if (a == c)
            {
                if (c == b)
                {
                    Console.WriteLine("podane boki moga stworzyc trojkat rownoboczny");
                }
                else
                {
                    Console.WriteLine("podane boki nie moga stworzyc trojkata rownobocznego");
                }
            }
            else
            {
                Console.WriteLine("podane boki nie moga stworzyc trojkata rownobocznego");
            }
        }
        else
        {
            Console.WriteLine("podane boki nie moga stworzyc trojkata rownobocznego");
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
