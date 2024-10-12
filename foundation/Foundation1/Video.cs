using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public int _commentAmount;
    public List<Comment> _comment;

    public void TrackTitle(string title)
    {
        _title = title;
    }
    public void TrackAuthor(string author)
    {
        _author = author;
    }
    public void TrackLength(int length)
    {
        _length = length;
    }
        public void CommentList()
    {
        
    }
    public void NumberOfComments(int commentAmount)
    {
        _commentAmount = commentAmount;
        // .Count function. and a list?
    }
    public string ReturnAString()
    {
        return $"{}"
    }

    Comment c = new Comment();
}
/* Your program should have a class for a Video
 that has the responsibility to track the title, 
 author, and length (in seconds) of the video. 
 Each video also has responsibility to store a 
 list of comments, and should have a method to 
 return the number of comments. */