
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _playerName;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _playerName = "Aventurero";
    }

    public void Start()
    {
        DisplayWelcome();

        string choice = "";
        while (choice != "6")
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create a new goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Meet goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Register Event");
            Console.WriteLine("  6. Quit");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }

        Console.Clear();
        Console.WriteLine($"Farewell, Noble {_playerName}! May your quests be victorious!");
        ShowSpinner(3);
    }

    private void DisplayWelcome()
    {

        Console.Clear();
        Console.WriteLine("////////////////////////////////////////////////////");
        Console.WriteLine("         ETERNAL QUEST: THE HERO'S CODEX     ");
        Console.WriteLine("////////////////////////////////////////////////////");
        Console.WriteLine("Greetings, Adventurer! Welcome to the realm of goals.");
        Console.WriteLine("Here, we'll turn your daily achievements into points of glory.\n");
        Console.WriteLine("Play, reach your goals, and have fun");

        Console.Write("Tell us, by what name are you known in these lands?: ");
        string inputName = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(inputName))
        {
            _playerName = inputName;
        }

        Console.WriteLine($"\nWelcome, {_playerName}!");
        Console.WriteLine("\n--- INSTRUCTIONS ---");
        Console.WriteLine("1. You can create 3 types of goals: Simple, Everlasting, or Checklist.");
        Console.WriteLine("2. Every time you achieve a goal in real life, log it here to earn points!");
        Console.WriteLine("3. As you earn points, you'll rise through the kingdom's ranks (from Squire to Legendary Lord).");
        Console.WriteLine("4. Remember to save your progress before you exit.");
        Console.WriteLine("==================================================\n");

        Console.Write("Preparing the guild's ledger... ");
        ShowSpinner(3);

        Console.WriteLine("\n\nPress ENTER to continue to the guild menu...");
        Console.ReadLine();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Noble {_playerName}, you have {_score} points of honor.");

        // Custom Level Ranges
        string level = "Novice Squire";

        if (_score >= 2000) level = "Lord of Legend 👑";
        else if (_score >= 1000) level = "Paladin of Truth 🛡";
        else if (_score >= 500) level = "Knight of the Order ⚔ ";
        else if (_score >= 200) level = "Adventurer of the Kingdom 🗡";

        Console.WriteLine($"Rank in the Kingdom: {level}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Las metas son:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("\nYour goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no recorded goals.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        Console.WriteLine("\nPress ENTER to return to the menu...");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.Write("\nCreating goal... ");
        ShowSpinner(2);
        Console.WriteLine("\nPress ENTER to return to the menu...");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        Console.Clear();
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals registered to record.");
            Console.WriteLine("\nPress ENTER to return to the menu...");
            Console.ReadLine();
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Console.Write("Recording event... ");
            ShowSpinner(2);
            Console.WriteLine();

            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;

            if (pointsEarned > 0)
            {
                Console.WriteLine($"Congratulations, {_playerName}! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have a total of {_score} points.");
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }

        Console.WriteLine("\nPress ENTER to return to the menu...");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("What is the name of the text file? ");
        string filename = Console.ReadLine();

        Console.Write("Saving goals... ");
        ShowSpinner(2);

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_playerName);
            outputFile.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("\n¡Goals saved successfully!✅");
        Console.WriteLine("\nPress ENTER to return to the menu...");
        Console.ReadLine();
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("What is the name of the file to be uploaded? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("The file you're looking for does not exist⚠.");
            Console.WriteLine("\nPress ENTER to return to the menu...");
            Console.ReadLine();
            return;
        }

        Console.Write("Loading goals... ");
        ShowSpinner(2);

        string[] lines = File.ReadAllLines(filename);

        _playerName = lines[0];
        _score = int.Parse(lines[1]);
        _goals.Clear();

        for (int i = 2; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split(':');
            string goalType = parts[0];
            string[] details = parts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                string name = details[0];
                string desc = details[1];
                int points = int.Parse(details[2]);
                bool isComplete = bool.Parse(details[3]);
                _goals.Add(new SimpleGoal(name, desc, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                string name = details[0];
                string desc = details[1];
                int points = int.Parse(details[2]);
                _goals.Add(new EternalGoal(name, desc, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = details[0];
                string desc = details[1];
                int points = int.Parse(details[2]);
                int bonus = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int amountCompleted = int.Parse(details[5]);
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus, amountCompleted));
            }
        }
        Console.WriteLine($"\nWelcome back, {_playerName}! Data loaded successfully.");
        Console.WriteLine("\nPress ENTER to return to the menu...");
        Console.ReadLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}