using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction test1 = new Fraction(2, 3);
        test1.GetFractionString();

        Fraction test2 = new Fraction();
        test2.GetFractionString();

        Fraction test3 = new Fraction(5);
        test3.GetFractionString();

        Fraction test4 = new Fraction();
        test4.SetTop();
        test4.SetBottom();
        test4.GetFractionString();
        test4.GetDecimalValue();
    }
}