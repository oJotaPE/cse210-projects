public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine("Event recorded for SimpleGoal!");
        }
        else
        {
            Console.WriteLine("Goal has already been completed.");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public string GetStringRepresentation()
    {
        // return $" {getDetail} {goals} - {_points} points) ";
        return GetDetailsString();
    }

}