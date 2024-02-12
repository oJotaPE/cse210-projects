using System.Runtime;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _description = description;
        _points = points;
        _shortName = name;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Event recorded for CheckListGoal! {_amountCompleted}/{_target} completed.");
        }
        else
        {
            Console.WriteLine("Goal has already been completed.");
        }
    }


    public override bool IsComplete()
    {
        bool isOrNot = false;
        if (_amountCompleted < _target)
        {
             isOrNot = false;
        }
        if (_amountCompleted == _target)
        {
            isOrNot = true;
        }
        return isOrNot;
    }

    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        string display = $"{checkbox} {_shortName} ({_description}) - {_points} points --- Completed: {_amountCompleted}/{_target}";
        return display;
    }

    public string GetStringRepresentation()
    {
        return GetDetailsString();
    }
}