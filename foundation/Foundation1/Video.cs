using System;

class Video
{
    public string _title;
    public string _author;
    public float _length;
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
    public void TrackLength(float length)
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
    // public string ReturnAString()
    // {
        // return $"{}";
    // }
        public void GatherComments()
    {
        foreach (Comment c in _comment)
        {
            Comment c = new Comment();
            c._name = "bill";
            c._text = "a short comment";
        }
    }
}
/* Your program should have a class for a Video
 that has the responsibility to track the title, 
 author, and length (in seconds) of the video. 
 Each video also has responsibility to store a 
 list of comments, and should have a method to 
 return the number of comments. */