public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
    : base(name, description, points)
    {
        _description = description;
        _points = points;
        _shortName = name;
    }

    public void RecordEvent()
    {

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