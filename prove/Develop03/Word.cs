using System;

// my design object/class
public class Word
{
// my design attributes/variables
// 'private' for encapsulation
private string _text;
private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    // this method replaces each letter in a hidden word with an underscore
    public string GetDisplayText()
    {
        // if it's true that it is hidden
        if (_isHidden)
        {
            // then:
            string _response = "";
            // declares that the variable i=0; for (as long as) i is less than _text.Count(); add 1 to i each time the loop completes.
            for (int i=0; i < _text.Count(); i++)
            {
                _response += "_";
            }
            return _response;
        }
        // if i is no longer less than _text.Count() then:
        return _text;
    }
}