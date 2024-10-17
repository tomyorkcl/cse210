using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        while (true)
        {
            Console.WriteLine("Welcome to Youtube Tracker Program!");
            Console.WriteLine("1. Add Video");
            Console.WriteLine("2. Add Comment to Video");
            Console.WriteLine("3. Show Comments for Video");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter video title: ");
                string title = Console.ReadLine();
                videos.Add(new Video(title));
                Console.WriteLine("Video added!");
            }
            else if (choice == "2")
            {
                Console.Write("Enter video title to add comment: ");
                string videoTitle = Console.ReadLine();
                Video video = videos.Find(v => v.Title.Equals(videoTitle, StringComparison.OrdinalIgnoreCase));

                if (video != null)
                {
                    Console.Write("Enter your name: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter your comment: ");
                    string text = Console.ReadLine();
                    video.AddComment(author, text);
                    Console.WriteLine("Comment added!");
                }
                else
                {
                    Console.WriteLine("Video not found!");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter video title to show comments: ");
                string videoTitle = Console.ReadLine();
                Video video = videos.Find(v => v.Title.Equals(videoTitle, StringComparison.OrdinalIgnoreCase));

                if (video != null)
                {
                    video.ShowComments();
                }
                else
                {
                    Console.WriteLine("Video not found!");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Bye, see you later! :)");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
            Console.WriteLine();
        }
    }
}