using Microsoft.VisualBasic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _promopts;

    public ListingActivity()
    {
        _count = 0;
        _promopts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are some positive changes you've noticed in yourself?",
            "What did you accomplish today and made you proud?.",
            "What personal strengths or talents do you possess?",
            "Who did you help recently?",
            "List three moments of joy or happiness you experienced today.",
            "When was the last time you overcame a challenge, and what did you learn?",
            "Who are your personal heroes or role models, and what qualities do you admire in them?",
            "Reflect on a time you made a positive impact on someone else's life.",
            "What are your goals or intentions for personal growth in the upcoming week?"
        };
        _description = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _name = "Listing activity";
        _duration = 0;
    }

    Random random = new Random();
    public string GetRandomPrompt()
    {
        int index = random.Next(_promopts.Count);
        return _promopts[index];
    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        List<string> answers = new List<String>();

        do
        {
            Console.Write("> ");
            string listing = Console.ReadLine();
            answers.Add(listing);

        } while (DateTime.Now < futureTime);
        foreach (string answer in answers)
        {
            _count = _count++;
        }
        Console.WriteLine($"You listed {answers.Count} items");
        return answers;
    }
    public void Run()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Thread.Sleep(3000);
        Console.Write("you may begin in: ");
        ShowCountDoun(5);
        Console.WriteLine();
        GetListFromUser();
    }
}