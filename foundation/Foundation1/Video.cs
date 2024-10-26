using System;
using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public float _length;
    public int _commentCount;
    public List<Comment> _comment;

    public Video (string title, string author, float length)
    {   // initializes list
        _comment = new List<Comment>();
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComments(Comment comment)
    {   // adds to list
        _comment.Add(comment);
    }
    public int CommentCount()
    {   // counts "items" in list
        return _comment.Count;
    }
    public string DisplayVideoInfo()
    {   // prints according to this setup
        return $"Title: {_title}\nCreator: {_author}\n{_length} seconds long.";
    }
    public void PrintComments()
    {
        foreach (var comment in _comment)
        {
            Console.WriteLine(comment.CommentSection());
        }
    }
}