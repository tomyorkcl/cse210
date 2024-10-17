using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; } // Length in seconds
    public List<Comment> Comments { get; private set; } = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(string author, string text)
    {
        Comments.Add(new Comment(author, text));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void ShowComments()
    {
        foreach (var comment in Comments)
        {
            Console.WriteLine($"{comment.Author}: {comment.Text}");
        }
    }
}