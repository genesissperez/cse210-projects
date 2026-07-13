using System;

class Program
{
    static void Main(string[] args)
    {
        // This is to create an empty list to store the integers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        // Loop for requesting numbers 
        while (userNumber != 0)
        {
            Console.Write("Enter a number(0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // IMPORTANT: Only this condition will add the number to the list if it is NOT 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // This is important. We only perform calculations if the user has entered at least one number.
        if (numbers.Count > 0)
        {
            // This is to calculate the total amount
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");


            // Compute the average 
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find the max 
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");


            // Smallest positive number ---
            int smallestPositive = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }


            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Sort the numbers ---
            numbers.Sort();

            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            // Mensaje amigable en caso de que escriban 0 al principio
            Console.WriteLine("No numbers were entered, so calculations cannot be performed.");
        }
    }
}