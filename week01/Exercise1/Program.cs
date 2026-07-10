using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for first name
        Console.Write("- What is your first name? ");
        string first = Console.ReadLine();

        // Ask for last name
        Console.Write("- What is your last name? ");
        string last = Console.ReadLine();

        //This is for a blank line
        Console.WriteLine();

        //Console.WriteLine is the "print" command in C#
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}