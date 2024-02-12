using System.Data.Common;
using System.IO.Enumeration;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

     public GoalManager()
     {
        _goals = new List<Goal>();
        _score = 0;

     }
     public void Start()
     {
        
     }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score: {_score}");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("List of Goal Names: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetShortName());
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("Goals: ");
        foreach (Goal goal in _goals)
        {
            if (goal != null)
            {
                Console.WriteLine($"\n{goal.GetDetailsString()}");
            }
        }

        Console.WriteLine("\n \nPress Enter to return to the menu...");
        Console.ReadLine();
    }
    public void CreateGoal( Goal newGoal)
    {
        _goals.Add(newGoal);
    }
    // public void RecordEvent()
    // {
    //     int Index = 0;
    //     foreach (Goal goal in _goals)
    //     {
    //         Index = Index ++;
    //         Console.WriteLine($"{Index}. {goal}");
    //     }
    //     Goal goal1 = new Goal();
    //     goal1.RecordEvent();

    // }
    public void RecordEvent()
    {
        Console.WriteLine("Select the goal number you want to record an event for:");
        string indexInput = Console.ReadLine();
        if (int.TryParse(indexInput, out int selectedIndex) && selectedIndex > 0 && selectedIndex <= _goals.Count)
        {
            Goal selectedGoal = _goals[selectedIndex - 1];
            selectedGoal.RecordEvent();
            Console.WriteLine("                          .___      __      ___.    \n   ____   ____   ____   __| _/     |__| ____\\_ |__  \n  / ___\\ /  _ \\ /  _ \\ / __ |      |  |/  _ \\| __ \\ \n / /_/  >  <_> |  <_> ) /_/ |      |  (  <_> ) \\_\\ \\ \n \\___  / \\____/ \\____/\\____ |  /\\__|  |\\____/|___  /\n/_____/                    \\/  \\______|          \\/ ");
            Console.Write("\n \n press enter to continue");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save your goals, with the .txt extension: ");
        string filename = Console.ReadLine();
        string filePath = Path.Combine(@"C:\Users\Usuario\Documents\João Pedro\software-dev\repositories\cse210-projects\prove\Develop05", filename);
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetDetailsString());
            }
        }

        Console.WriteLine($"Goals saved to {filename}");
    }
    // public void LoadGoals()
    // {
    //     Console.Write("Enter the filename to save your goals, with the .txt extension: ");
    //     string filename = Console.ReadLine();
    //     string filePath = Path.Combine(@"C:\Users\Usuario\Documents\João Pedro\software-dev\repositories\cse210-projects\prove\Develop05", filename);

    //     using (StreamReader load = new StreamReader(filePath))
    //     {
    //         string data;
    //         while ((data = load.ReadLine()) != null)
    //         {
    //             Console.WriteLine(data);
    //         }
    //     }
    // }
    public void LoadGoals()
    {
        Console.Write("Enter the filename to load your goals, with the .txt extension: ");
        string filename = Console.ReadLine();
        string filePath = Path.Combine(@"C:\Users\Usuario\Documents\João Pedro\software-dev\repositories\cse210-projects\prove\Develop05", filename);

        //clean the older goals before I start
        _goals.Clear();
        string [] lines = System.IO.File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            Goal goal = CreateGoalFromLine(line);
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals Loaded Successfully");
    }

    private Goal CreateGoalFromLine(string Line)
    {
        String[] parts = Line.Split(',');
        if (parts.Length >= 3)
        {
            string name = parts[0].Trim();
            string description = parts[1].Trim();
            string points = parts[2].Trim();
        }
        return null;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }
}