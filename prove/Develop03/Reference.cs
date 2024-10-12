using System;

// my design object/class
public class Reference
{
// my design attributes/variables
private string _book;
private int _chapter;
private int _verse;
private int _endVerse;
// declares the variables to be called and filled in the Program file. see line 9 in Program.cs.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }
    // same as the above method, but for two verse selectors.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    // displays the reference, but has to be called into the Program.cs file and printed.
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
        return $"{_book} {_chapter}:{_verse}";
        }
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}