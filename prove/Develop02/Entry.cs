public class Entry
{
    
    string entryBackup = "";
    //create a prompting list
    public List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "what did I learn today?",
        "What was my favorite meal in the day and what did I eat?",
        "What was the funniest moment of my day?",
        "What challenges did I face today? Did I overcome them?"
    };

    public string ChooseRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public (string Answer, DateTime EntryDateTime) NewEntry()
    {
        Console.WriteLine(ChooseRandomPrompt());
        Console.Write("> ");
        string answer = Console.ReadLine();

        DateTime currentDate = DateTime.Now;
        return (answer, DateTime.Now);
    }



    public string _makeAVariable()
    {
        string question = ChooseRandomPrompt();
        string answer = NewEntry();

    }
}