public class Lecture : Event
{
    private string _type;
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity)
     : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = "Lecture";
        _capacity = capacity;
        _speaker = speaker;
    }

    public string GenerateFull()
    {
        return $"\n-----\n{_title} \n{_date} - {_time} \n \n{_address} \n\n{_description} \n\nspeaker: {_speaker} \ncapacity {_capacity}\n-----\n";
    }

    public string GenerateShort()
    {
        return $"\n------\nType: {_type} \nTitle: {_title} \nDate: {_date} \n------\n";
    }
}