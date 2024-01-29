// using System;
// using System;
// using System.IO;
// using System.Text.Json;
// using System.Collections.Generic;


// class Program
// {
//     static void Main(string[] args)
//     {
//         ScriptureList scriptureList = new ScriptureList();
//         Reference reference = new Reference("Lucke", 2, 4, 6);
//         Random random = new Random();

//         scr
//         do
//         {


//             bool hideOrNor = word1.IsHidden();

//             List<string> wordList = scriptureList.ReturnWords();
//             string finalReference = reference.GetDisplayText();

//             Scripture scripture = new Scripture(finalReference, wordList);
//             string display = scripture.GetDisplayText();
//             Console.Clear();
//             Console.WriteLine(display);

//             Word word1 = new Word(wordList);
//             foreach (string word in wordList)
//             {
//                 int randomNumber = random.Next(1, 20);
//                 if (randomNumber > 10)
//                 {
//                     word1.Hide();
//                 }
//                 else if (randomNumber < 10 && hideOrNor == false)
//                 {
//                     word1.Show();
//                 }
//             } while ()
//         }

//     }
// }
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
