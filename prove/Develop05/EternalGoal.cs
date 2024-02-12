public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
    : base(name, description, points)
    {
        _description = description;
        _points = points;
        _shortName = name;
    }

    // public override void RecordEvent()
    // {
    //     Console.WriteLine("Enter the number of the goal you want to record: ");
    //     string indexInput = Console.ReadLine();
    //     int aIndex = int.Parse(indexInput);
    //     int index = aIndex - 1;
    //     GoalManager goalManager = new GoalManager();
    //     List<Goal> list = goalManager.GetGoals();

    // }
    public override void RecordEvent()
    {
        Console.WriteLine("Enter the number of the goal you want to record: ");
        string indexInput = Console.ReadLine();
        int aIndex = int.Parse(indexInput);
        int index = aIndex - 1;
        GoalManager goalManager = new GoalManager();
        List<Goal> list = goalManager.GetGoals();

    }

    public override bool IsComplete()
    {
        return false;
    }
    
    public string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}