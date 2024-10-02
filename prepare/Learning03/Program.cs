using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        // Fraction f1 = new Fraction();
        // Fraction f2 = new Fraction(6);
        // Fraction f3 = new Fraction(6,7);

        // Console.WriteLine(f1.DisplayMath());
        // Console.WriteLine(f2.DisplayMath());
        // Console.WriteLine(f3.DisplayMath());

        // Fraction f = new Fraction();
        // f.SetTopNumber(4);
        // Console.WriteLine(f.GetTopNumber());

        // Fraction f4 = new Fraction();
        // f4.SetBottomNumber(8);
        // Console.WriteLine(f4.GetBottomNumber());

        Fraction f5 = new Fraction();
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        // in this section and below the instance takes
        // parameters in the form of ints.
        Fraction f6 = new Fraction(5);
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());

        Fraction f7 = new Fraction(3,4);
        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetDecimalValue());

        Fraction f8 = new Fraction(1,3);
        Console.WriteLine(f8.GetFractionString());
        Console.WriteLine(f8.GetDecimalValue());
    }
}