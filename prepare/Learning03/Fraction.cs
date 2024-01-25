using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    //Making the variables private so no code out of this file can access it
    private int _top;
    private int _bottom;

    //constructor 1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //constructor 2
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    //constructor 3
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //display method is supposed to print the value of the fraction on screen
    public void GetFractionString()
    {
        string top = _top.ToString();
        string bottom = _bottom.ToString();
        string fractionString = top + "/" + bottom;
        Console.WriteLine($" the fraction is {fractionString}");
    }
    //making it a decimal value
    public void GetDecimalValue()
    {
        double decimalValue = (double)_top / _bottom;
        Console.WriteLine($"the dacimal value is {decimalValue}");
    }

    //getter sand setters
    public int SetTop()
    {
        Console.Write("Enter a top value: ");
        string topInput = Console.ReadLine();
        int TopValue = int.Parse(topInput);
        _top = TopValue;
        return _top;
    }

    public int SetBottom()
    {
        Console.Write("Enter a top value: ");
        string bottomInput = Console.ReadLine();
        int bottomValue = int.Parse(bottomInput);
        _bottom = bottomValue;
        return _bottom;
    }

    public int GetTop()
    {
        int finalTop = _top;
        return finalTop;
    }
    public int GetBottom()
    {
        int finalBottom = _bottom;
        return finalBottom;
    }

}