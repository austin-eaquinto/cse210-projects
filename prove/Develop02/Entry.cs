public class Entry
{
    // i forget the importance of creating these 'method parameters'(?) variables
    // and how they store information
    public string _date;
    public string _promptText;
    public string _entryText;

    // method that writes the variables to the terminal
    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }

    // returns a string to the text file... 
    public override string ToString()
    {
        return $"{_date},{_promptText},{_entryText}";
    }

}