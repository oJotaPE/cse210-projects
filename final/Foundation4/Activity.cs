public abstract class Activity
{
    protected int _distance;
    protected int _speed;
    protected double _pace;
    protected int _time;//always in minutes
    protected List<string> _summary; //set the list as an attribute
    
    public Activity()
    {
        _summary = new List<string>(); //start the summary 
    }

    public abstract int CalculateDistance();

    public int CalculateSpeed()
    {
        int calculation = (_distance / _time) * 60;
        _speed = calculation;
        return calculation;

    }
    public double CalculatePace()
    {
        double calculation = (double)_time / _distance;
        _pace = calculation;
        return calculation;
    }

    public virtual string AddSummary()
    {
        DateTime date = DateTime.Now.Date; //.Date will get only the date information instead of current date and time
        string stringSpeed = _speed.ToString();
        string stringTime = _time.ToString();
        string stringPace = string.Format("{0:0.00}", _pace);//limit pace to 2 decimal points
        string stringDistance = _distance.ToString();

        string data = $"-  {date:dd/MM/yyyy} Exercise ({stringTime}) - Distance: {stringDistance}, Speed: {stringSpeed} kph, Pace: {stringPace} per KM)";
        return data;
    }

    public List<string> GetSummary()
    {
        return _summary;
    }
} 