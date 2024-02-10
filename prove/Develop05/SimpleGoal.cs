public class SimpleGoal : Goal
{
    private bool _isComplete;
    // public SimpleGoal(string name, string description, string points)
    // {
    //     _shortName = name;
    //     _description = description;
    //     _points = points;
    //     _isComplete = false;
    // }
    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public void RecordEvent()
    {

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