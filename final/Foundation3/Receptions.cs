public class Reception : Event
{    private string _type;
    private int _registrations;

    public Reception(string title, string description, string date, string time, string address, int registrations)
     : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = "Reception";
        _registrations = registrations;
    }

    public string GenerateFull()
    {
        return $"{_title} \n{_date} - {_time} \n{_address}\n\n{_description} \n \n-----\n{_registrations} Registrated\n-----\n";
    }

    public string GenerateShort()
    {
        return $"\n ------\nType: {_type} \nTitle: {_title} \nDate: {_date} \n------\n";
    }
}