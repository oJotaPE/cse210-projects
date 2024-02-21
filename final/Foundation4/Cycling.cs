public class Cycling : Activity
{    
    public Cycling(int speed, int time)
    {
        _speed = speed;
        _time = time;
    }
    public override int CalculateDistance()
    {
        int calculation = _time * _speed;
        _distance = calculation;
        return calculation;
    }

    public override string AddSummary()
    {
        DateTime date = DateTime.Now.Date; //.Date will get only the date information instead of current date and time
        string stringSpeed = _speed.ToString();
        string stringTime = _time.ToString();
        string stringPace = string.Format("{0:0.00}", _pace);//limit pace to 2 decimal points
        string stringDistance = _distance.ToString();

        string data = $"-  {date:dd/MM/yyyy} Cycling ({stringTime}) - Distance: {stringDistance}, Speed: {stringSpeed} kph, Pace: {stringPace} per KM)";
        // _summary.Add(data);
        return data;
    }
} 