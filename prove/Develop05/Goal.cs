public abstract class Goal 
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    // public Goal(string name, string description, string points)
    // {
    //     _ShortName = name;
    //     _description = description;
    //     _points = points;

    // }
    public virtual void abstractRecordEvent()
    {

    }
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        string status = IsComplete() ? "[x]" : "[ ]";
        return $"{status} {_shortName} ({_description}) {_points} points";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName} ({_description} - {_points})";
    }

}