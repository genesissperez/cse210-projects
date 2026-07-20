using System;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, string text)
    {
        // empty
    }


    public void HideRandomWords(int numberToHide)
    {
        // empty
    }

    public string GetDisplayText()
    {
        return ""; // Returns an empty string 
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}