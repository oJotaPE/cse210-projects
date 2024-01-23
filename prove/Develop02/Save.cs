
public class Save
{
    public void _saveToFile(List<string> answers, string filepath)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                foreach (string entry in answers)
                {
                    sw.WriteLine(entry);
                }
                Console.WriteLine($"Journal saved to {filepath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void _appendToFile(List<string> answers, string filepath)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                foreach (string entry in answers)
                {
                    sw.WriteLine(entry);
                }
                Console.WriteLine($"Journal saved to {filepath}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }
}