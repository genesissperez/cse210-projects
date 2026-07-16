using System;

public class Entry
{

    public string _date;  // Stores the date the post was created
    public string _promptText; // Store the prompt
    public string _entryText; // Stores the user's written response


    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }

    public string GetFormattedString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}