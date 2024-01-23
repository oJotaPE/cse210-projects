using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Setting the variable responsible for menu
        string showItAll = "0";

        //invoking other classes to create instances
        Entry entry = new Entry();
        Display display = new Display();
        Menu save = new Menu();
        Quit quitProgram = new Quit();

        do //until the user presses 5
        {
            //present menu 
            Menu startMenu = new Menu();
            showItAll = startMenu.DisplayMenu();

            //type a new entry
            if (showItAll == "1")
            {
                
                entry.NewEntry();
            }

            //display on screen
            else if (showItAll == "2")
            {
               
                display._DisplayCurrent(entry.answers);
            }

            //load from other file
            else if (showItAll == "3")
            {

            }

            //save on a file
            else if (showItAll == "4")
            {
                save._SaveJournal(entry.answers);
            }

            //quit program
            else if (showItAll == "5")
            {
                
                quitProgram._thankUser();
            }
        } while(showItAll != "5");
    }
}