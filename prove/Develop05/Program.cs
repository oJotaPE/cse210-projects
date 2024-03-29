using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

//Added an ascii art at the end of the record goals to congratulate the user everytime they finish a goal

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exitRequested = false;

        while (!exitRequested)
        {
            string choice;
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Events\n   6. Quit");
            Console.Write("\nSelect the choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
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
                        // Console.WriteLine();
                        // Console.WriteLine();
                        // Console.WriteLine(simpleGoal.GetStringRepresentation());
                        goalManager.CreateGoal(simpleGoal);
                    }
                    else if (goalType == "2")
                    {
                        Console.Clear();
                        Console.Write("What is a good name for your goal? ");
                        string inputName = Console.ReadLine();
                        Console.Write("Enter a description for your goal? ");
                        string inputDescription = Console.ReadLine();
                        Console.Write("How many points will you earn for this? ");


                        string inputPoints = Console.ReadLine();
                        EternalGoal eternalGoal = new EternalGoal(inputName, inputDescription, inputPoints);
                        // Console.WriteLine();
                        // Console.WriteLine();
                        // Console.WriteLine(eternalGoal.GetStringRepresentation());
                        goalManager.CreateGoal(eternalGoal);

                    }

                    else if (goalType == "3")
                    {
                        Console.Clear();
                        Console.Write("What is a good name for your goal? ");
                        string inputName = Console.ReadLine();
                        Console.Write("Enter a description for your goal? ");
                        string inputDescription = Console.ReadLine();
                        Console.Write("How many points will you earn for this? ");
                        string inputPoints = Console.ReadLine();
                        Console.Write("How many times do you want to complete the goal? ");
                        string inputTarget = Console.ReadLine();
                        Console.Write("What is the value of the bonus you will recieve after all times are completed? ");
                        string inputBonus = Console.ReadLine();

                        int target = int.Parse(inputTarget);
                        int bonus = int.Parse(inputBonus);


                        CheckListGoal checklistGoal = new CheckListGoal(inputName, inputDescription, inputPoints, target, bonus);
                        // Console.WriteLine();
                        // Console.WriteLine();
                        // Console.WriteLine(checklistGoal.GetStringRepresentation());
                        goalManager.CreateGoal(checklistGoal);
                    }
                    break;

                case "2":
                    Console.Clear();
                    goalManager.ListGoalDetails();
                    break;

                case "3":
                    Console.Clear();
                    goalManager.SaveGoals();
                    break;

                case "4":
                    Console.Clear();
                    goalManager.LoadGoals();
                    break;

                case "5":
                    Console.Clear();
                    goalManager.RecordEvent();
                    break;

                case "6":
                    exitRequested = true;
                    Console.Clear();
                    Console.WriteLine("Thank you for your time");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        };
    }
}