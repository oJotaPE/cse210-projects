using System.Runtime.CompilerServices;

public class Menu
{
    public string _ChosenOption = "";

    public string DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Choose one of the following:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine();
        return choice;
    }



    public void DisplayJournal(List<string> answerList)
    {
        Display display = new Display();
        display._DisplayCurrent(answerList);
    }

    public void _SaveJournal(List<string> answerList)
    {
        Save saveToFile = new Save();
        Console.WriteLine("Choose one of the following:");
        Console.WriteLine("1. Create new file");
        Console.WriteLine("2. Save on loaded file");

        Console.Write("> ");
        string choice = Console.ReadLine();

        string fileName;

        if (choice == "1")
        {
            Console.Write("Enter the file name, no extensions or folders:  ");
            fileName = Console.ReadLine();
            fileName = "C:\\Users\\Usuario\\Documents\\João Pedro\\software-dev\\repositories\\cse210-projects\\prove\\Develop02\\" + fileName + ".txt";
            saveToFile._saveToFile(answerList, fileName);
        }
        else if (choice == "2")
        {
            Console.Write("Enter the loaded file name, no extensions or folders  : ");
            fileName = Console.ReadLine();
            fileName = "C:\\Users\\Usuario\\Documents\\João Pedro\\software-dev\\repositories\\cse210-projects\\prove\\Develop02\\" + fileName + ".txt";
            saveToFile._appendToFile(answerList, fileName);
        }
        else if (choice == "3")
        {
            Console.WriteLine("Enter the name of the file to be loaded, no extentions or folders: ");
            string name = Console.ReadLine();
            Load load = new Load();
            load._loadTheFile(name);
            
        }
        else
        {
            Console.WriteLine("Invalid choice.");
            return;
        }
    }
}
