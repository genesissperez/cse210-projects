using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine("\n--- Testing Getters and Setters ---");

        Fraction f5 = new Fraction(); // Starts on 1/1

        // Change the object's data using the "Set" methods.
        f5.SetTop(6);
        f5.SetBottom(7);

        // Retrieve values securely using the Get method 
        Console.WriteLine($"New modified f5 counter: {f5.GetTop()}");
        Console.WriteLine($"New modified denominator for f5: {f5.GetBottom()}");

        // Verify the final result 
        Console.WriteLine($"Final section f5: {f5.GetFractionString()}");

    }
}