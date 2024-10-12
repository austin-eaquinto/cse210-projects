using System;

public class Comment
{
    public string _name;
    public string _text;

    public void TrackName(string name)
    {
        _name = name;

    }
    public void TrackText(string text)
    {
        _text = text;
    }
}
/*  A comment should be defined by the Comment 
class which has the responsibility for tracking both 
the name of the person who made the comment and the 
text of the comment. */