using System;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }



    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty. Write something first!");
            return;
        }

        Console.WriteLine("\n====================== JOURNAL ENTRIES ======================");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("=============================================================");
    }


    // Saves all entries to a text file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetFormattedString());
            }
        }
        Console.WriteLine($"\n[Success] Your journal was saved to '{file}' successfully!");
    }



    // Loads from file and alerts the user
    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"\n[Error] The file '{file}' does not exist.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._promptText = parts[1];
                loadedEntry._entryText = parts[2];

                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine($"\n[Success] Loaded {_entries.Count} entries from '{file}'.");
    }
}
