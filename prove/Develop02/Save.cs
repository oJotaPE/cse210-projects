public class Save
{
    public string filename = "";

    public void CreateFile()
    {
        Console.WriteLine("Enter a file name for your Journal, do not type the extension or folder to save");
        Console.Write("> ");
        string nameForFile = Console.ReadLine();
        filename = nameForFile;

        if (!string.IsNullOrWhiteSpace(filename))
        {
            // Combine the filepath with the filename given by the user
            string directoryPath = @"C:\Users\Usuario\Documents\cse210-projects-1\prove\Develop02\";
            string filePath = Path.Combine(directoryPath, filename + ".txt");

            // Check if the directory exists and create if it doesn't
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Generate the file
            File.Create(filePath);

            // Add the question, answer, and date to the same file
            using (var file = new StreamWriter(filePath, true))
            {
                file.WriteLine("test");
            }
        }
        else
        {
            Console.WriteLine("Name not found, the file could not be generated.");
        }
    }
}