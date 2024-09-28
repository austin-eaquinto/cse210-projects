using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        PromptGenerator newPrompt = new PromptGenerator();
        Journal myJournal = new Journal();

        do{
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Enter the number: ");
            response = Console.ReadLine();

                if (response == "1")
                {
                    string prompt = newPrompt.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Entry newEntry = new Entry();
                    DateTime now = DateTime.Now;
                    newEntry._date = now.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._entryText = Console.ReadLine();
                    // newEntry.DisplayEntry();
                    myJournal.AddEntry(newEntry);
                }

                else if (response == "2")
                {
                    myJournal.DisplayAll();
                    // newEntry.DisplayEntry();
                }

                else if (response == "3")
                {
                    LoadFromFile();
                }

                else if (response == "4")
                {
                    myJournal.SaveToFile();
                }
        }while (response != "5");

        // i need this page to access the journal page through display, load, and save
        // the write option will write to the entry page, entries will be saved to the journal
    }
}