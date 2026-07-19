using System;

// Every object created with the `fraction` class will represent a mathematical fraction.
public class Fraction
{
    private int _top;    // This variable stores the numerator 
    private int _bottom; // This variable stores the denominator of the fraction


    //It is important that the program create the fraction 1/1 .
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Represent an integer as a fraction (example: 5 becomes 5/1).
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }


    // This is for creating any custom fraction by passing its numerator and denominator.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // This part allows the program to "read" or retrieve the current value of the numerator.
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }



    //to get the current value of the denominator.
    public int GetBottom()
    {
        return _bottom;
    }


    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    // It is important for the program to return the fraction in a visually readable format, such as "3/4" or "1/3."
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }


    //  calculate and obtain the actual result of the division in decimal
    public double GetDecimalValue()
    {

        return (double)_top / (double)_bottom;
    }
}