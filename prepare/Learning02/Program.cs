using System;

class Program
{
    static void Main(string[] args)
    {   
        Job job1 = new Job();
        job1.Company = "Microsoft";
        job1.JobTitle = "Software Engineer";
        job1.StartYear = 2019;
        job1.EndYear = 2022;

        Job job2 = new Job();
        job2.Company = "Apple";
        job2.JobTitle = "Manager";
        job2.StartYear = 2022;
        job2.EndYear = 2023;

        Resume resume = new Resume();
        resume.Name = "Brent Smith";

        resume.Jobs.Add(job1);
        resume.Jobs.Add(job2);

        resume.Display();
    }
    
}