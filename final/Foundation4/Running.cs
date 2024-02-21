public class Running : Activity
{

    //always pass in time as minutes
    public Running(int distance, int time)
    {
        _distance = distance;
        _time = time;
    }

    public override int CalculateDistance()
    {
        return _distance;
    }
    public override string AddSummary()
    {
        DateTime date = DateTime.Now.Date; //.Date will get only the date information instead of current date and time
        string stringSpeed = _speed.ToString();
        string stringTime = _time.ToString();
        string stringPace = string.Format("{0:0.00}", _pace);//limit pace to 2 decimal points
        string stringDistance = _distance.ToString();

        string data = $"-  {date:dd/MM/yyyy} Running ({stringTime}) - Distance: {stringDistance}, Speed: {stringSpeed} kph, Pace: {stringPace} per KM)";
        // _summary.Add(data);
        return data;
    }

} 