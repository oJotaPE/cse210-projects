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

    public string WriteJournal()
    {
        Entry newDescription = new Entry();
        // (string answer, DateTime entryDateTime) = newDescription.NewEntry();
        string answer = newDescription.NewEntry();
        return answer;

    }
}