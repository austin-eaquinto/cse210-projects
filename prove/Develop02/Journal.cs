using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = [];
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    }
    public void SaveToFile(string file)
    {
        string filename = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine("");
        }
    }
    public void LoadFromFile(string file)
    {
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}