using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Swimming swimming = new Swimming(5, 7);
        Running running = new Running(11, 30);
        Cycling cycling = new Cycling(35, 20);

        List<Activity> AllActivities = new List<Activity>
        {
            swimming,
            running,
            cycling
        };

        foreach (Activity activity in AllActivities)
        {
            string summary = activity.AddSummary();
            Console.WriteLine(summary);
        }

    }
}
// create new objects and add to the list from here