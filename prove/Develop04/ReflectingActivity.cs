public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "think of a time when you were stressed and had to calm down.",
            "think of a time when you had a real problem or hard situation and had to think of a way to go through it."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };
        _name = "Reflecting Activity";
        _description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
    }

    Random random = new Random();
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        int index = random.Next(_questions.Count);
        // _questions.Remove(_questions[index]);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.Clear();
        ShowSpinner(200,3);
        Console.WriteLine($"\n ---{GetRandomPrompt()}---");
    }

    public void DisplayQuestions()
    {
        int time = 0;
        do
        {
            Console.Write($"\n> {GetRandomQuestion()}\n");
            ShowSpinner(200, 4);
            time = time + 9;
        } while(time <= _duration);

    }


    public void Run()
    {
        DisplayPrompt();
        Console.WriteLine("After you have something in mind, press enter to continue.");
        string toContinue = Console.ReadLine();
        if (toContinue == "") 
        {
            Console.WriteLine("Now, ponder on each of the following questions as they related to this experiende.");
            Console.Write($"you may begin in: ");
            ShowCountDoun(5);
            
            Console.WriteLine();
            DisplayQuestions();
        }
    }
}