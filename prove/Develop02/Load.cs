using System.IO.Enumeration;
using System.Runtime.CompilerServices;

public class Load
{

    List<string> loaded = new List<string>()
    {
        
    };
    
    string fileName = "";
    
    public List<string> _loadTheFile(string fileName)
    {
        string filePath = "C:\\Users\\Usuario\\Documents\\João Pedro\\software - dev\\repositories\\cse210 - projects\\prove\\Develop02\\" + fileName + ".txt";
        using (StreamReader load = new StreamReader(filePath))
        {
            string data;
            while((data = load.ReadLine()) != null)
            {
                loaded.Add(data);
                Console.WriteLine(data);
            }
        }
        return loaded;
    }
}