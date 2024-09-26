using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Oracle";
        job1._startYear = 1998;
        job1._endYear = 2002;

        Job job2 = new Job();
        job2._jobTitle = "CEO";
        job2._company = "Apple";
        job2._startYear = 2003;
        job2._endYear = 2012;

        Resume myResume = new Resume();
        myResume._name = "Hayley Williams";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}