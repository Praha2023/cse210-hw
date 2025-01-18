using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "software engineering";
        job1._company = "Apple";
        job1._startYear = 2019;
        job1._endYear = 2022;

        

        Job job2 = new Job();
        job2._jobTitle = "business managment";
        job2._company = "microsoft";
        job2._startYear = 2022;
        job2._endYear = 2023;

        
        Resume myResume = new Resume();
        myResume._name = "pravallika guttaveelli";

        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume.Display();


    }
}