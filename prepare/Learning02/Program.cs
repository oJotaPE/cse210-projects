using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Call job and add jobs to be iterated on the list
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2023;
        // job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Apple Inc.";
        job2._startYear = 2020;
        job2._endYear = 2021;
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Daniel Riveira";

        //Add these jobs to my job list inside resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Show it all on the screen
        myResume.DisplayResume();
    }
}