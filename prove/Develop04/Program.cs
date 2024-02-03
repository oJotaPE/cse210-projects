using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        //Display menu
        string choice = "12";
        void menu()
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\n   1. Start breathing activity\n   2. Start Reflecting activity\n   3. Start listing activity\n   4. Quit");
            Console.Write("\nEnter the choice: ");
            choice = Console.ReadLine();
        };
        menu();


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
            menu();
        }
        if (choice == "2")
        {
            Console.Clear();
            reflectingActivity.ShowSpinner(200, 2);
            reflectingActivity.DisplayStartingMessage();
            Console.WriteLine();
            reflectingActivity.Run();
            Console.WriteLine();
            reflectingActivity.DisplayEndingMessage();
            reflectingActivity.ShowSpinner(200, 2);
            menu();

        }
    }
}