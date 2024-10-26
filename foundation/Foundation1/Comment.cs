using System;

class Comment
{
    public string _name;
    public string _text;

    public Comment(string name, string text)
    {
        _text = text;
        _name = name;
    }
    public string CommentSection()
    {
        return $"User {_name} said:\n{_text}";
    }
}