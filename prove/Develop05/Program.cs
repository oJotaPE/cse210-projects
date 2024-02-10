//I exceed what's expected because in my program, when saving the changes, I give the user the oportunity to save
//the new entries in an already existing file, just typing the name of the file

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Events\n   6. Quit");
        Console.Write("\nSelect the choice: ");
        choice = Console.ReadLine();


        if (choice == "6")
        {
            Console.Clear();
            Console.WriteLine("Thank you for your time");
        }

        else if (choice == "1")
        {
            Console.WriteLine("these are the types of goals to create:");
            Console.WriteLine("\n   1. Simple Goal\n   2. Eternal Goal\n   3. Checklist Goal");
            Console.Write("Which do you want to do? ");
            string goalType = Console.ReadLine();

            if (goalType == "1")
            {
                Console.Clear();
                Console.Write("What is a good name for your goal? ");
                string inputName = Console.ReadLine();
                Console.Write("Enter a description for your goal? ");
                string inputDescription = Console.ReadLine();
                Console.Write("How many points will you earn for this? ");
                string inputPoints = Console.ReadLine();
                SimpleGoal simpleGoal = new SimpleGoal(inputName, inputDescription, inputPoints);
                Console.WriteLine();
                Console.WriteLine(simpleGoal.GetStringRepresentation());
            }
        }
    }
}