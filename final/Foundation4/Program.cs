using System;

class Program
{
    static void Main(string[] args)
    {
        // Running running = new Running(11, 10);
        // running.CalculateDistance();
        // running.CalculateSpeed();
        // running.CalculatePace();

        // running.AddSummary();
        // foreach (string register in running.GetSummary())
        // {
        //     Console.WriteLine($"{register} \n");
        // }
        // Swimming swimming = new Swimming(5, 10);
        // swimming.CalculateDistance();
        // swimming.CalculateSpeed();
        // swimming.CalculatePace();

        // swimming.AddSummary();
        // foreach (string register in swimming.GetSummary())
        // {
        //     Console.WriteLine($"{register} \n");
        // }

        // Cycling cycling = new Cycling(30, 60);
        // cycling.CalculateDistance();
        // cycling.CalculateSpeed();
        // cycling.CalculatePace();

        // cycling.AddSummary();
        // foreach (string register in cycling.GetSummary())
        // {
        //     Console.WriteLine($"{register} \n");
        // }
        Swimming swimming = new Swimming(5, 7);
        Running running = new Running(11, 30);
        Cycling cycling = new Cycling(35, 20);

        string swimmingINfo = swimming.AddSummary();
        string runningInfo = running.AddSummary();
        string cyclingInfo = cycling.AddSummary();

        

    }
}
 // create new objects and add to the list from here