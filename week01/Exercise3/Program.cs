using System;

class Program
{
    static void Main(string[] args)
    {
        // --- WELCOME  ---
        Console.WriteLine("****WELCOME TO THE 'GUESS MY NUMBER' GAME****");
        Console.WriteLine();
        Console.WriteLine("Instructions: write a number from 1 to 100");
        Console.WriteLine("---------------------------------------------");

        // Variable to start the game if the user wishes 
        string playAgain = "yes";

        // The main loop
        while (playAgain.ToLower() == "yes")
        {
            // Generate a random number 
            Random randomGenerator = new Random();
            // Generate numbers from 1 to 100
            int magicNumber = randomGenerator.Next(1, 101);


            int guess = -1;

            // Counter     
            int guessCount = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                // Here, I need to add 1 to the attempt counter for each opportunity
                guessCount++;


                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }


            Console.WriteLine($"It took you {guessCount} guesses.");


            Console.WriteLine();
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }


        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}