using System;
using System.Security.Cryptography.X509Certificates;

//exceeding requirements and creativity: 
// In my reflecting activity, inside the get random questions, 
//to make the user reflect under the speciffic topic, I added a 
//.remove() code to prevent the system from using the same question more than once

class Program
{
    static void Main(string[] args)
    {
        // Creating instances
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        //Display menu
        string choice = "12";
        void menu()
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\n   1. Start breathing activity\n   2. Start Reflecting activity\n   3. Start listing activity\n   4. Quit");
            Console.Write("\nEnter the choice: ");
            choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for your time.");
            }

            else if (choice == "1")
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
            else if (choice == "2")
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
            else if (choice == "3")
            {
                Console.Clear();
                listingActivity.ShowSpinner(200, 2);
                listingActivity.DisplayStartingMessage();
                Console.WriteLine();
                listingActivity.Run();
                Console.WriteLine();
                listingActivity.DisplayEndingMessage();
                listingActivity.ShowSpinner(200, 2);
                menu();

            }
        };
        menu();



    }
}