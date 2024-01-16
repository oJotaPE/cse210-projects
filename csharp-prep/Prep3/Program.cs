using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string stringNumber = Console.ReadLine();
        int number = int.Parse(stringNumber);

        int guess = 999999;
        do
        {
            Console.Write("Enter yout guess: ");
            string stringGuess = Console.ReadLine();
            guess = int.Parse(stringGuess);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);
    }
}