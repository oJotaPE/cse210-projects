public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    
    public Event(string tittle, string description, string date, string time, string address)
    {
        _title = tittle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GenerateStandard()
    {
        return $"\n------\n{_title} \n{_date} - {_time} \n{_address} \n\n{_description} \n------\n";
    }
}

