public class Cycling : Activity
{    
    public Cycling(double speed, int time)
    {
        _speed = speed;
        _time = time;
        _distance = (int)((double)_time *_speed);
        _pace = (double)_time / _distance;
    }
    // public override int CalculateDistance()
    // {
    //     int calculation = 
    //      = calculation;
    //     return calculation;
    // }

    public override string AddSummary()
    {
        DateTime date = DateTime.Now.Date; //.Date will get only the date information instead of current date and time
        string stringSpeed = _speed.ToString();
        string stringTime = _time.ToString();
        string stringPace = string.Format("{0:0.00}", _pace);//limit pace to 2 decimal points
        string stringDistance = _distance.ToString();

        string data = $"-  {date:dd/MM/yyyy} Cycling ({stringTime}) - Distance: {stringDistance} km, Speed: {stringSpeed} kph, Pace: {stringPace} min per KM)";
        // _summary.Add(data);
        return data;
    }
} 