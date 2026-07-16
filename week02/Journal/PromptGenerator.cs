using System;
//The purpose of this file in the program is to identify the available questions
// and randomly select one for the user.Important!
public class PromptGenerator
{

    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the Lord's hand in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I could change just one thing about today, what would it be?");
    }

    //This part of the code selects a random question and returns it
    public string GetRandomPrompt()
    {

        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count);
        return _prompts[index];
    }
}