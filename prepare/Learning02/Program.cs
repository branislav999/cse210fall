using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Developer";
        job1._startYear = 2020;
        job1._endYear = 2021;
        // job1.Display();

        Resume resume1 = new Resume();
        resume1._name = "Branislav Bogosavac";
        resume1._jobs.Add(job1);
        resume1.Display();


    }
}