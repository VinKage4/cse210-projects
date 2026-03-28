using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructor with no parameters
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test constructor with one parameter
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test constructor with two parameters
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test getters and setters
        Fraction f5 = new Fraction();
        f5.SetTop(6);
        f5.SetBottom(7);

        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine($"Top: {f5.GetTop()}");
        Console.WriteLine($"Bottom: {f5.GetBottom()}");
        Console.WriteLine(f5.GetDecimalValue());
    }
}