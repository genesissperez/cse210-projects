using System;

//I added a formatted welcome menu with introductory instructions before displaying the main menu and some emojis to improve the user experience.
//The outputs were formatted with visual separators and user-friendly status messages.

class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        Console.WriteLine("===========================================");
        Console.WriteLine(" 🔹 Welcome to the Mindfulness Moment 🔹 ");
        Console.WriteLine("===========================================");
        Console.WriteLine("This app will help you unwind from the stress of the day,");
        Console.WriteLine("Think about your accomplishments and focus on the positive.");
        Console.WriteLine("Select an option from the menu to get started.");
        Console.WriteLine("...........................................");
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();

        string menuOption = "";

        while (menuOption != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1️⃣ Start breathing activity");
            Console.WriteLine("  2️⃣ Start reflecting activity");
            Console.WriteLine("  3️⃣ Start listing activity");
            Console.WriteLine("  4️⃣ Quit");
            Console.Write("Select a choice from the menu: ");

            menuOption = Console.ReadLine();

            if (menuOption == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (menuOption == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (menuOption == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }

        Console.WriteLine("\nThanks for taking some time for yourself! See you later.");
    }
}