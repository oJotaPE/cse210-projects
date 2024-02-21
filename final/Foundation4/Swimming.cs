public class Swimming : Activity
{
    private int _laps;

    //always pass in time as minutes
    public Swimming(int laps, int time)
    {
        _laps = laps;
        _time = time;
        _distance = _laps * 50 / 100;
        _pace = (double)_time / _distance;
        _speed = (double)60 / _pace;

    }

    // public override int CalculateDistance()
    // {
    //     int calculation = _laps * 50 / 100;
    //     int _distance = calculation;
    //     return calculation;
    // }

    public override string AddSummary()
    {
        DateTime date = DateTime.Now.Date; //.Date will get only the date information instead of current date and time
        string stringSpeed = _speed.ToString();
        string stringTime = _time.ToString();
        string stringPace = string.Format("{0:0.00}", _pace);//limit pace to 2 decimal points
        string stringDistance = _distance.ToString();

        string data = $"-  {date:dd/MM/yyyy} Swimming ({stringTime}) - Distance: {stringDistance} Km, Speed: {stringSpeed} kph, Pace: {stringPace} min per KM)";
        // _summary.Add(data);
        return data;
    }


} 