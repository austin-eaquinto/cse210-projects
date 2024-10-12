using System;
// for 'exceeds requirements' I have code that replaces words that aren't already hidden.
// I learned about the .ToLower method from chatgpt
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        Reference r = new Reference("John", 3, 16);
        string script = "For God so loved the world, that he gave " + 
                        "his only begotten Son, that whosoever believeth in him " + 
                        "should not perish, but have everlasting life.";

        Reference r2 = new Reference("Proverbs", 3, 5, 6);
        string proverb = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                         "In all thy ways acknowledge him, and he shall direct thy paths.";

        // Scripture class constructor called here in an instance/object.
        Scripture s = new Scripture(r, script);
        Scripture s1 = new Scripture(r2, proverb);

        // clears the console from all the load info
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Enter 'quit' to quit.");

        // sets the scripture class GetDisplayText into a variable
        string verse = s.GetDisplayText();
        // calls the variable
        Console.WriteLine(verse);
        // calls the reference class GetDisplayText. I di not store it in a variable
        Console.WriteLine(r.GetDisplayText());
        // a do while loop. It runs the program once as if it were not in the loop
        // and then continues the loop.
        do
        {
            // frustrated and chose the variable name as 'hey'
            string hey = Console.ReadLine();
            // .ToLower makes it so that if quit is entered as 'Quit' it changes
            // it back to 'quit' in the program to match here.
            if (hey.ToLower() != "quit")
            {
                // calls the scripture class HideRandomWords method and the 3
                // is how many words will be hidden
                s.HideRandomWords(3);
                // calls the variable to be used inside the if statement
                verse = s.GetDisplayText();
                // clears console again
                Console.Clear();
                // prints the verse with hidden words
                Console.WriteLine(verse);
                // prints reference again
                Console.WriteLine(r.GetDisplayText());
            }
            else
            {
                // ends the loop if the if statement condition is met
                break;
            }
        // the loop continues to run while the verse is NOT completely hidden.
        }while (!s.IsCompletelyHidden());
    }
}