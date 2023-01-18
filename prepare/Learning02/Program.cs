using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobs = "Programmer";
        job1._company = "Microsoft";
        job1._startYear = 2012;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._jobs = "Developer";
        job2._company = "Youtube";
        job2._startYear = 2019;
        job2._endYear = 2020;

        // job1.display();
        resume name1 = new resume();
        name1._name = "Xiomara";
        name1._jobTitle.Add(job1);
        name1._jobTitle.Add(job2);
        name1.displayJobs();
    }
}