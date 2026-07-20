using System;

public class Reference
{

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;



    public Reference(string book, int chapter, int verse)
    {
        // empty for now
    }

    // Verse Builder
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        // empty for now
    }


    public string GetDisplayText()
    {
        return ""; // Returns an empty string
    }
}