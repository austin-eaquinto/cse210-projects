using System.IO;

public class Journal
{
    // creates a list. there are a few ways to do this. this is a compact way.
    public List<Entry> _entries;
    public Journal()
    {
        // brings in the list and makes it empty
        _entries = [];
    }
    public void AddEntry(Entry newEntry)
    {
        // adds to the list with 'Add'
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        // another way to say this is 'for each line in the txt file'
        foreach (Entry e in _entries)
        {
            // do this method (function) a line at a time. if you look at the 
            // DisplayEntry method in the Entry class you can see how it's built
            e.DisplayEntry();
        }
    }
    
    //  prompt user to enter which file to save to
    public void SaveToFile(string file)
    {
        // puts the file into a variable
        string filename = "journal.txt";
        // creates the file? the 'true' allows for adding(appending) to the text file
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (Entry e in _entries)
            {
                // teacher says this line is wrong, but the code works?
                outputFile.WriteLine(e);
            }
        }
    }
    
    // prompt the user to enter which file to load.
    // not sure what the 'string file' means right now, just that it works.
    public void LoadFromFile(string file)
    {
        string filename = "journal.txt";
        // the 'ReadAllLines' is a built in function that does a thing. gotta
        // study this line.
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // this is either supposed to split on a comma, or it adds a comma
            // where there is a space/break/split in the entry variables.
            string[] parts = line.Split(",");

            // string firstName = parts[0];
            // string lastName = parts[1];
        }
    }
    public void ReadFromFile()
    {
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        // 'writes' out the txt file for display and reading into the terminal.
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}