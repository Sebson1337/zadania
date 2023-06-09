using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d, x, y;

        Console.WriteLine("dodawanie ulamkow, podaj a(licznik pierwszego ulamka)");
        a = (int)inputValue();
        Console.WriteLine("podaj b, mianownik pierwszego ulamka");
        b = (int)inputValue();
        Console.WriteLine("podaj c, licznik drugiego ulamka");
        c = (int)inputValue();
        Console.WriteLine("podaj d, mianownik drugiego ulamka");
        d = (int)inputValue();
        
        if (b == d)
        {
            x = a + c;
            y = b;
            Console.WriteLine("licznik wynosi=" + x);
            Console.WriteLine("mianownik wynosi=" + y);
        }

        else
        {
            
               while(b!=d)
            {
                b = b + 1;

            }
            x = a + c;
            y = b;
            Console.WriteLine("licznik wynosi=" + x);
            Console.WriteLine("mianownik wynosi=" + y);

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

//Console.WriteLine("licznik wynosi=" + x);
//Console.WriteLine("mianownik wynosi=" + y);

