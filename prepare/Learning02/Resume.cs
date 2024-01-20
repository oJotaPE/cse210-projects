//To create a class I don't need to add parentheses or anything like this, just set it as public and as a class
//Each class must have its own file
public class Resume
{
    //the attributes first
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //now the method
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}