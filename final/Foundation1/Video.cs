using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _seconds;

    List<Comment> _comments = new List<Comment>{};

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"\nTitle: {_title}, Author: {_author}, Length: {_seconds} seconds.");
        Console.WriteLine($"Number of Comments on this video is: {CommentCount()}");
        foreach (Comment com in _comments)
        {
            Console.WriteLine($"User {com._name} commented: {com._text} ");
        }
    }


    public int CommentCount()
    {
        int sum = 0;
        foreach (Comment comment in _comments)
        {
            sum++;
        }
        return sum;
    }
}

