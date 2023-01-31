using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDEecimalValue());

        Fraction fraction2 = new Fraction(1);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDEecimalValue());

        Fraction fraction5 = new Fraction(5);
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDEecimalValue());

        Fraction fraction3 = new Fraction(3,4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDEecimalValue());

        Fraction fraction4 = new Fraction(1,3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDEecimalValue());

    }
}