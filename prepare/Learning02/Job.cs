//Setting the name of the class
public class Job
{
    //giving it some attributes, to store the tittle of the position, name of the company and the period working
    public string _jobTitle = "";
    public string _company = "";
    public int _startYear;
    public int _endYear;

    // giving it a behavior
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}