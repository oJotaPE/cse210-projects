using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        // Entry entry = new Entry();
        // entry.NewEntry();
        string showItAll = "0";
        Entry entry = new Entry();
        Display display = new Display();
        Quit quitProgram = new Quit();
        
        do
        {
            Menu startMenu = new Menu();
            showItAll = startMenu.DisplayMenu();
            if (showItAll == "1")
            {
                
                entry.NewEntry();
            }
            else if (showItAll == "2")
            {
               
                display._DisplayCurrent(entry.answers);
            }
            else if (showItAll == "3")
            {

            }
            else if (showItAll == "4")
            {
                Console.WriteLine("Choose one of the following:");
                Console.WriteLine("1. Create new file");
                Console.WriteLine("2. Save on loaded file");
                Console.Write(">");
                string SaveOptions = Console.ReadLine();

                if (SaveOptions == "1")
                {

                }
            }
            else if (showItAll == "5")
            {
                
                quitProgram._thankUser();
            }
        } while(showItAll != "5");
    }
}