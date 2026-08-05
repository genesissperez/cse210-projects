using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Reflection Exercise", "This activity will help you recall moments when you were strong and overcame challenges, \neven though you may not have realized it at the time.It will remind you of what you're truly capable of.")
    {
        _prompts = new List<string>
        {
            "* Think of a time when you were able to stand up for someone else.",
            "* Remember a time when you had to do something that was really hard for you.",
            "* Think of a time when you helped someone in need without thinking twice.",
            "* Remember a time when you did something good without expecting anything in return."
        };

        _questions = new List<string>
        {
            "* Why was that experience important to you?",
            "* Had you ever done anything like that before?",
            "* How did you take the first step, or how did you get started?",
            "* How did you feel right after that experience?",
            "* What made this time different from other situations?",
            "* What did you like most about what happened?",
            "* What lesson did you learn from this that you can use in the future?",
            "* What did you learn about yourself from this?",
            "* How can you remember this when you face a problem again?"

        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_durationInSeconds);

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Read the following situation:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(10);
        Console.WriteLine();
    }
}