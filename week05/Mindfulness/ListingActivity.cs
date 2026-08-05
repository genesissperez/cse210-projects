using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect on the good things in your life\nby having you list as many things as you can in a certain area.")
    {
        _count = 0;
        _prompts = new List<string>
        {
            "* Who are the people you cherish most in your life?",
            "* What would you say are your best qualities or strengths?",
            "* Who have you helped this week?",
            "* When have you felt at peace or happy this week or this month?",
            "* Who do you consider your heroes or role models because they inspire you?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Write as many answers as you can on:");
        GetRandomPrompt();
        Console.Write("Take a breath and get ready to write in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"Well done!!😊 You managed to score {_count} points.");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationInSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                list.Add(input);
            }
        }

        return list;
    }
}