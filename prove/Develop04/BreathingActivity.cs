public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _description = $"relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _name = "Breathing Activity";
        _duration = 0;
    }
    public void Run()
    {
        int time = 0;

        ShowSpinner(200, 2);
        Console.Clear();
        do
        {
            Console.Write("\n\nbreathe in...");
            ShowCountDoun(5);
            Console.Write("\nBreathe out...");
            ShowCountDoun(5);
            time = time + 12;

        }while (time <= _duration);
    }
}