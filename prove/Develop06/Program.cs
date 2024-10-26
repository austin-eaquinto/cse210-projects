using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop06 World!");
        string response = "";
        // GoalManager goalSave = new GoalManager();
        GoalManager goalManager = new();

        while (response != "6")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            response = Console.ReadLine();

            if (response == "1")
            {
                goalManager.CreateGoal();
            }
            else if (response == "2")
            {
                // goalManager.ListGoalNames();
                goalManager.ListGoalDetails();
            }
            else if (response == "3")
            {
                Console.Write("What file would you like to save to? ");
                string saveFile = Console.ReadLine();
                if (saveFile == "goal.txt")
                {
                    Console.WriteLine("Saving...");
                    // calls the SaveToFile method from the Journal class
                    goalManager.SaveGoals("goal.txt");
                }
                else if (saveFile != "goal.txt")
                {
                    Console.WriteLine("Please choose an existing file.");
                }
            }
            else if (response == "4")
            {
                Console.Write("What file would you like to load? ");
                string loadFile = Console.ReadLine();
                if (loadFile == "goal.txt")
                {
                    Console.WriteLine("Loading...");
                    // calls the LoadFromFile method from the Journal class 
                    goalManager.LoadGoals("goal.txt");
                }
                else if (loadFile != "goal.txt")
                {
                    Console.WriteLine("Please select an existing file.");
                }
            }
            else if (response == "5")
            {
                goalManager.RecordEvent();
            }
            else if (response == "6")
            {
                break;
            }
        } 
    }
}