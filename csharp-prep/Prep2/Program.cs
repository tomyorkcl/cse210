using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage? ");
        string Value = Console.ReadLine();

        int number = int.Parse(Value);
        string grade = "";


        if (number > 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else if (number < 60)
        {
            grade = "F";
        }


        Console.WriteLine("Here your result: ");

        if (number >= 70)
        {
            Console.WriteLine($"Your grade is {grade}. You aprove the course!");
        }
        else
        {
            Console.WriteLine("You don't passed, try again next time!");
        }
    }
}