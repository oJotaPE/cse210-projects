public class Outdoor : Event
{
    private string _type;
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address)
     : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = "Outdoor Gathering";
        _weather = "unknown";
    }

    public string GenerateFull()
    {
        return $"\n ------\n{_title} \n{_date} - {_time} \n{_address}\n\n{_description} \nWeather Forecast {_weather}\n-----\n";
    }

    public string GenerateShort()
    {
        return $"\n ------\nType: {_type} \nTitle: {_title} \nDate: {_date}\n------\n";
    }
}