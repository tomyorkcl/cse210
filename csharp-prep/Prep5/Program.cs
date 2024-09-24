using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int SquareNumber = InputSquareNumber(userNumber);
        DisplayResult(userName, userNumber, SquareNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to my program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int InputSquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name,int number, int square)
    {
        Console.WriteLine($"{name}, the square of {number}, is {square}.");
    }
}

//I added an other function in PRINT, now you can now what number you put in prompt