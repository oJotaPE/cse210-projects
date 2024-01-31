using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assignment = new WritingAssignment();
        MathAssignment mathAssignment = new MathAssignment();

        assignment.SetTopic("World War II");
        assignment.SetName("Jonas");
        assignment.SetTittle("A different look");
        mathAssignment.SetTextbook(7.8f);
        mathAssignment.SeProblems(22, 26);
        
        Console.WriteLine(assignment.GetWritingInformation());
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomework());

    }
}