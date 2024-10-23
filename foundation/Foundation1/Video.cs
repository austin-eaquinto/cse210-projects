using System;
using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public float _length;
    public int _commentCount;
    public List<string> _comment;

    public Video ()
    {   // initializes list
        _comment = new List<string>();
    }
    public void AddComments(string comments)
    {   // adds to list
        _comment.Add(comment);
    }
    public int CommentCount()
    {   // counts "items" in list
        return _comment.Count;
    }
    public string DisplayVideoInfo()
    {   // prints according to this setup
        return $"Tile: {_title}\nCreator {_author}\n{_length} seconds long."
    }
    public void PrintComments()
    {
        foreach (var comment in _comment)
        {
            Console.WriteLine(comment);
        }
    }
    public string GetComments()
    {
        Comment c = new Comment();
        return c.CommentSection();
    }
}
/* Your program should have a class for a Video
 that has the responsibility to track the title, 
 author, and length (in seconds) of the video. 
 Each video also has responsibility to store a 
 list of comments, and should have a method to 
 return the number of comments. */