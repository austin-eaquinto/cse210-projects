// "Exceeded Requirements" by making it so additional information can be save to the file.

using System;

// This is where the classes are called in and used.
class Program
{
    static void Main(string[] args)
    {
        // create the variable outside of the loop beforehand
        string response = "";
        // if i understand correctly, these are instances
        PromptGenerator newPrompt = new PromptGenerator();
        Journal myJournal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program.");
        // a do/while loop so the program runs through once first, and then starts the loop
        do{
            // these are repeated each time after an action is completed
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Enter the number: ");
            // user response number as a string
            response = Console.ReadLine();

                if (response == "1")
                {
                    // the 'GetRandomPrompt' is a method in the PromptGenerator class that
                    // calls the random function applied to the 'newPrompt' variable which
                    // holds the list of prompts in the PromptGenerator class.
                    string prompt = newPrompt.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    // another instance
                    Entry newEntry = new Entry();
                    // records just the date and time the entry was entered
                    DateTime now = DateTime.Now;
                    // i think this formats the DateTime to only display the date
                    newEntry._date = now.ToShortDateString();
                    // as i understand it, this accesses the Entry class for writing
                    // and creates the '_promptText' variable by storing the prompt
                    // variable inside of it which already has the code in it mentioned
                    // above.
                    newEntry._promptText = prompt;
                    // both _promptText and _entryText come from the Entry class.
                    // this line takes in the user input for a journal entry.
                    newEntry._entryText = Console.ReadLine();
                    // if line 14 'Journal myJournal = new Journal();' is an instance, this would
                    // be like a reference to that instance. and line 36 too, i think. this accesses
                    // the journal class through the Entry class? 
                    // Firgure this part out better.
                    myJournal.AddEntry(newEntry);
                }

                else if (response == "2")
                {
                    // calls method from the Journal class that itself calls a method from the Entry class.
                    myJournal.DisplayAll();
                    // calls method from the Journal class that accesses the txt file for display.
                    myJournal.ReadFromFile();
                }

                // these next to else if make it possible for the user to enter the file to save to. this
                // can be built on to include more files(right now it's just programmed as like a 'true/false')
                // and options.
                else if (response == "3")
                {
                    Console.Write("What file would you like to load? ");
                    string loadFile = Console.ReadLine();
                    if (loadFile == "journal.txt")
                    {
                        Console.WriteLine("Loading...");
                        // calls the LoadFromFile method from the Journal class 
                        myJournal.LoadFromFile("journal.txt");
                    }
                    else if (loadFile != "journal.txt")
                    {
                        Console.WriteLine("Please select an existing file.");
                    }
                }

                else if (response == "4")
                {
                    Console.Write("What file would you like to save to? ");
                    string saveFile = Console.ReadLine();
                    if (saveFile == "journal.txt")
                    {
                        Console.WriteLine("Saving...");
                        // calls the SaveToFile method from the Journal class
                        myJournal.SaveToFile("journal.txt");
                    }
                    else if (saveFile != "journal.txt")
                    {
                        Console.WriteLine("Please choose an existing file.");
                    }
                    
                }
        // ends the program if the 'response == "5"'
        }while (response != "5");
    }
}