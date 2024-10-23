// Used help and learned from the tutoring lab for the 'this' operation and correctly displaying lists, 
// and learned about 'Stopwatch' from ai.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");
        string choice = "-1";
        while (choice != "4")
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            // BreathingActivity
            if (choice == "1")
            {
                    BreathingActivity ba = new BreathingActivity();
                    ba.Run();
            }
            // ReflectingActivity
            else if (choice == "2")
            {
                    ReflectingActivity ra = new ReflectingActivity();
                    ra.Run();
            }
            // ListingActivity
            else if (choice == "3")
            {
                    ListingActivity la = new ListingActivity();
                    la.Run();
            }
            // end program
            else if (choice == "4")
            {
                break;
            }
        }

    }
}