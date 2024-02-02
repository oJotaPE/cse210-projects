public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "no activity";
        _description = "No activity was chosen so there is no description or purpose";
        _duration = 0;
    }
    public Activity(string name, string description, int duration)
    {
        _duration = duration;
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"This activity will {_description}\n");
        Thread.Sleep(2000);
        Console.Write("Enter how many seconds you would like to do the following activity: ");
        string wantedTime = Console.ReadLine();
        int input = int.Parse(wantedTime);
        _duration = input;

    }
    public void DisplayEndingMessage()
    {
        Thread.Sleep(3000);
        Console.WriteLine($"\nCongratulations, you have done {_duration} seconds of {_name}");
    }

    public void ShowSpinner(int seconds, int timeSpinning)
    {
        int timerSeconds = timeSpinning;
        Console.Write("\\");
        do
        {
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            Console.Write("\\");

            timerSeconds = timerSeconds - 1;
        } while (timerSeconds > -1);
    }

    public void ShowCountDoun(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        for (int i = seconds; i > 0; i--)
        {

            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        // Thread.Sleep(3000);

        // DateTime currentTime = DateTime.Now;
        // if (currentTime < futureTime)
        // {
        //     Console.WriteLine($"waitng...");
        // }        
    }
}