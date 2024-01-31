public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }
    public Assignment()
    {
        _name = "unknown";
        _topic = "no topic";
    }

    public string GetSummary()
    {
       return $"name: {_name} \ntopic {_topic}" ;
    }

    public string GetName()
    {
        return _name;
    }


    public string GetTopic()
    {
        return _topic;
    }


    public void SetName(string name)
    {
        _name = name;

    }


    public void SetTopic(string topic)
    {
        _topic = topic;
    }
}
