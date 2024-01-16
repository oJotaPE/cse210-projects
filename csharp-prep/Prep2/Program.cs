using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        int gradeValue = int.Parse(input);
        string grade = "F";

        if (gradeValue >= 90)
        {
            grade = "A";
        }
        else if (gradeValue >= 80)
        {
            grade = "B";
        }
        else if (gradeValue >= 70)
        {
            grade = "C";
        }
        else if (gradeValue >= 60)
        {
            grade = "D";
        }
        else if (gradeValue < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        string status = "-";
        if (gradeValue >= 70)
        {
            status = "Positive";
            Console.WriteLine($"Congratulations! your status is {status}");
        }
        else
        {
            status = "Negative";
            Console.WriteLine($"Your status is {status}, try again next semester! ");
        }

        


    }
}