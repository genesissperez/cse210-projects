using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("==========================================================");
        Console.WriteLine("        WELCOME TO THE SCRIPTURE MEMORIZER TOOL           ");
        Console.WriteLine("==========================================================");
        Console.WriteLine("\nPurpose:");
        Console.WriteLine("This program helps you memorize scriptures by gradually replacing");
        Console.WriteLine("Instructions:");
        Console.WriteLine("1. Read the scripture displayed on the screen.");
        Console.WriteLine("2. Press ENTER to hide a few random words.");
        Console.WriteLine("3. Try to recite the scripture, filling in the hidden words.");
        Console.WriteLine("4. Repeat until all words are hidden, or type 'quit' to exit.");
        Console.WriteLine("==========================================================");
        Console.WriteLine("\nPress ENTER to start practicing...");
        Console.ReadLine();


        // Variable to track whether the user wants to play/practice again
        bool keepPracticing = true;

        // loop to repeat the entire program if the user wishes.
        while (keepPracticing)
        {
            //scriptures 
            List<Scripture> scriptureLibrary = new List<Scripture>
            {
                new Scripture(
                    new Reference("1 Nephi", 3, 7),
                    "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
                ),
                new Scripture(
                    new Reference("Joshua", 1, 9),
                    "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest."
                ),
                new Scripture(
                    new Reference("Psalms", 23, 1, 2),
                    "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters."
                ),
                new Scripture(
                    new Reference("2 Nephi", 2, 25),
                    "Adam fell that men might be; and men are, that they might have joy."
                ),
                new Scripture(
                    new Reference("Mosiah", 2, 17),
                    "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."
                )
            };



            Random random = new Random();
            Scripture selectedScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            string userInput = "";

            //  Loop to hide words in the selected text.
            while (userInput.ToLower() != "quit" && !selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press ENTER to hide words or type 'quit' to exit this scripture:");

                userInput = Console.ReadLine();

                if (userInput.ToLower() != "quit")
                {
                    selectedScripture.HideRandomWords(3);
                }
            }

            // If you managed to hide all the words, we'll show you the final result
            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine("\nCongratulations! All words in the scripture are hidden.");
            }


            Console.WriteLine("\nWould you like to practice another scripture? (yes/no):");
            string response = Console.ReadLine().ToLower();

            if (response != "yes" && response != "y")
            {
                keepPracticing = false;
            }
        }

        Console.WriteLine("\nProgram finished. Great job practicing!");
    }
}

