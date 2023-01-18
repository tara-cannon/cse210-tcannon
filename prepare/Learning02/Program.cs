using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Our Livingroom";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2005;
        job1._endYear = 2023;

        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "The Kitchen";
        job2._jobTitle = "Ice Cream Eater";
        job2._startYear = 1984;
        job2._endYear = 2035;

        //job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Tara Cannon";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.DisplayResumeDetails();

    }
}