using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        PromptGenerator promptCreator = new PromptGenerator();

        bool runProgram = true;
        Console.WriteLine("Welcome to the Journal Program!");

        while (runProgram)
        {
            // --- NEW MENU ---
            Console.WriteLine("\n=== JOURNAL MENU ===");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();



            switch (choice)
            {
                case "1":
                    string prompt = promptCreator.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    DateTime currentTime = DateTime.Now;
                    string dateText = currentTime.ToShortDateString();

                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;

                    theJournal.AddEntry(newEntry);



                    Console.WriteLine("\n[Success] Your entry has been recorded in memory!");
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("\nWhat is the filename?");
                    Console.Write("> ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.WriteLine("\nWhat is the filename?");
                    Console.Write("> ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    Console.WriteLine("\nThank you for writing today! Goodbye.");
                    runProgram = false;
                    break;

                default:
                    Console.WriteLine("\n[Error] Invalid choice. Please select a number from 1 to 5.");
                    break;
            }
        }
    }
}