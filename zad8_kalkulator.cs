using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, d;

        Console.WriteLine("podaj rodzaj dzialania: 1 - dodawanie , 2 - odejmowanie, 3 - możenie , 4 - dzielenie");
        a = inputValue();
        if (a == 1)
        {
            Console.WriteLine("podaj pierwsza liczbe");
            b = inputValue();
            Console.WriteLine("podaj druga liczbe");
            c = inputValue();
            d = b + c;
            Console.WriteLine(d);
        }
        else
        {
            if (a == 2)
            {
                Console.WriteLine("podaj pierwsza liczbe");
                b = inputValue();
                Console.WriteLine("podaj druga liczbe");
                c = inputValue();
                d = b - c;
                Console.WriteLine(d);
            }
            else
            {
                if (a == 3)
                {
                    Console.WriteLine("podaj pierwsza liczbe");
                    b = inputValue();
                    Console.WriteLine("podaj druga liczbe");
                    c = inputValue();
                    d = b * c;
                    Console.WriteLine(d);
                }
                else
                {
                    if (a == 4)
                    {
                        Console.WriteLine("podaj pierwsza liczbe");
                        b = inputValue();
                        Console.WriteLine("podaj druga liczbe");
                        c = inputValue();
                        if (c == 0)
                        {
                            Console.WriteLine(b +"/0");
                        }
                        else
                        {
                            if (b == 0)
                            {
                                Console.WriteLine(c+"/0");
                            }
                            else
                            {
                                d = b / c;
                                Console.WriteLine(d);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("podano zly rodzaj dzialania");
                    }
                }
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
