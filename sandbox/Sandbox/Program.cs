using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your favorite color? ");
        string favColor = Console.ReadLine();

        if (favColor == "blue")
        {
            Console.WriteLine("You have a good opinion");
        }

        else if (favColor == "black" || favColor == "purple")
        {
            Console.WriteLine("Your opninion makes me sleepy");
        }

        else
        {
            Console.WriteLine("You don't matter for me");
        }
    }
}