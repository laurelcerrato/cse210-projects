using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString( int _top, int _bottom)
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDEecimalValue( int _top, int _bottom)
    {
        double division = _top/_bottom;
        return division;
    }
}