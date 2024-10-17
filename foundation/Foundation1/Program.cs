class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // list of videos that I select
        Video video1 = new Video("Ice Cream", "Blackpink", 180);
        video1.AddComment("Byron", "XD!");
        video1.AddComment("Bob", "nice song :D");
        video1.AddComment("Carlos", "Diaj Reggaeton music is better.");

        Video video2 = new Video("SOS", "Jonas Brothers", 455);
        video2.AddComment("Dave", "What a song!");
        video2.AddComment("Eve", "I remembered my childhood :,)");
        
        Video video3 = new Video("Making code with Python", "Tom York", 245);
        video3.AddComment("Frank", "Loving python!");
        video3.AddComment("Grace", "I cant believe that Python is more friendly than C#");


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            video.ShowComments();
            Console.WriteLine();
        }
    }
}