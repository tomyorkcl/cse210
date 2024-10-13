using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi 2:10");

        Scripture scripture = new Scripture(reference, "And he also spake unto Lemuel: O that thou mightest be like unto this valley, firm and steadfast, and immovable in keeping the commandments of the Lord!");

        do
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideWords();
        } while (!scripture.AllWordsHidden());
    }
}