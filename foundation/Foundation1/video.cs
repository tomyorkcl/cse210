public class Video
{
    public string Title { get; private set; }
    public List<Comment> Comments { get; private set; } = new List<Comment>();

    public Video(string title)
    {
        Title = title;
    }

    public void AddComment(string author, string text)
    {
        Comments.Add(new Comment(author, text));
    }

    public void ShowComments()
    {
        foreach (var comment in Comments)
        {
            Console.WriteLine($"{comment.Author}: {comment.Text}");
        }
    }
}