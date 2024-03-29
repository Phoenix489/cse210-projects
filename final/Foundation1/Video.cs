using System.Reflection;

public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;

    public Video(string title, string author, string length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._name} - {comment._commentText}");
        }
        Console.Write("\n");
    }

     public string DisplayInfo()
    {
        return $"Title: {_title} - Author: {_author} - Length: {_length} - #ofComments: {ReturnCommentNumber(_comments)}\n ";
    }

    public int ReturnCommentNumber(List<Comment> _comments)
    {
        int count = _comments.Count;
        return count;
    }
}