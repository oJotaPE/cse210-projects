using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of ScriptureList to get a list of words
        ScriptureList scriptureList = new ScriptureList();

        // Create an instance of Reference
        Reference reference = new Reference("Luke", 2, 4, 6);

        // Create an instance of Scripture using the reference and the list of words
        Scripture scripture = new Scripture(reference, scriptureList.Luke24to6);

        // Display the complete scripture text
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        // Loop until all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // Hide a few random words and display the text again
            scripture.HideRandomNumbers(2); // Adjust this value as needed
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}
