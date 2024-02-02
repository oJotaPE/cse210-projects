using System;

class Program
{
    static void Main(string[] args)
    {
        // Activity teste = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("\n   1. Start breathing activity\n   2. Start Reflecting activity\n   3. Start listing activity\n   4. Quit");
        Console.Write("\nEnter the choice: ");
        string choice = Console.ReadLine();

        if(choice == "4")
        {
            Console.Clear();
            Console.WriteLine("Thank you for your time.");
        }

        if (choice == "1")
        {
            Console.Clear();
            breathingActivity.ShowSpinner(200, 2);
            breathingActivity.DisplayStartingMessage();
            Console.WriteLine();
            breathingActivity.Run();
            Console.WriteLine();
            breathingActivity.DisplayEndingMessage();
        }
    }
}