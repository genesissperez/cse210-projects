using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Mostrar el mensaje de bienvenida
        DisplayWelcome();

        // 2. Pedir el nombre del usuario y guardarlo
        string userName = PromptUserName();

        // 3. Pedir el número favorito del usuario y guardarlo
        int userNumber = PromptUserNumber();

        // 4. Calcular el cuadrado del número usando la función correspondiente
        int squaredNumber = SquareNumber(userNumber);

        // 5. Mostrar el resultado final pasando el nombre y el número al cuadrado
        DisplayResult(userName, squaredNumber);
    }

    // --- AQUÍ EMPIEZAN LAS FUNCIONES ---

    // Muestra el mensaje de bienvenida
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Pide y regresa el nombre del usuario (regresa un string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Pide y regresa el número favorito (regresa un int)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Acepta un número entero, calcula su cuadrado y lo regresa (regresa un int)
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Recibe el nombre y el número al cuadrado para mostrarlos en pantalla
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}