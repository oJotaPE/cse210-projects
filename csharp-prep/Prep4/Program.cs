using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputnumber = 99999917;
        int total = 0;
        int max = 0;
        int min = 99999900;
        do
        {
            Console.Write("Enter a number to the list, type '0' to stop: ");
            string stringInputNumber = Console.ReadLine();
            inputnumber = int.Parse(stringInputNumber);

            if (inputnumber != 0)
            {
                numbers.Add(inputnumber);
            }
            
        } while(inputnumber != 0);

        int listSize = numbers.Count;
        Console.WriteLine("numbers in the list:");

        foreach(int number in numbers)
        {
            total = total + number;
            Console.WriteLine(number);
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
        int averageValue = total / listSize;
        Console.WriteLine($"this is the total amount: {total}");
        Console.WriteLine($"this is the average: {averageValue}");
        Console.WriteLine($"this is the maximum value: {max}");
        Console.WriteLine($"this is the minimum value: {min}");

    }
}