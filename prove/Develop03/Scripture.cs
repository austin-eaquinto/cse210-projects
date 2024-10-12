using System;

public class Scripture
{
private Reference _reference;
private List<Word> _words;

    // the constructor? it gets called in the main Program.
    public Scripture(Reference reference, string text)
    {
        _words = new List<Word>();
        ConvertText(text);
        _reference = reference;
    }
    public void HideRandomWords(int numberToHide)
    {
        // calls the Random function and stores it in the variable 'random'
        Random random = new Random();
        int hiddenWords = 0;
        int wordsLeft = 0;
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                wordsLeft++;
            }
        }
        // variable names make this self explanatory
        if (wordsLeft < numberToHide)
        {
            numberToHide = wordsLeft;
        }
        // self explanatory
        while (hiddenWords < numberToHide)
        {
            // puts the random function (by the list of words) into a variable
            int randomIndex = random.Next(_words.Count);
            // this part confuses me
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                // ++ is the same as += in Python.
                hiddenWords++;
            }
        }
        // first section sets the value
        // second compares the variable to numberToHide
        // third adds one to the variable each time it loops successfully
        // for (int number=0; number < numberToHide; number++)
        // {
        //     int randomIndex = random.Next(_words.Count);
        //     _words[randomIndex].Hide();
        // }
    }
    // displays the whole scripture. this plays in to displaying the hidden words.
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word item in _words)
        {
            text += " " + item.GetDisplayText();
        }
        return text;
    }
    // checks if the whole list of words is hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            // if it's not all hidden
            if (!w.IsHidden())
            {
                // then
                return false;
            }
        }
        return true;
    }
    // splits the list by each space between words into individual items.
    private void ConvertText(string text)
    {
        string[] convert = text.Split(" ");

        // for each word in text
        foreach(string item in convert)
        {
            // w = each word
            Word w = new Word(item);
            // add that word to the list.
            _words.Add(w);
        }
    }
}