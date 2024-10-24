using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Jorge Araya", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Javiera Palma", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Anibal Ramirez", "Chilean History", "The Causes of Pacific War");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}