using System;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }
    // public void Start()
    // {

    // }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your score: {_score}");
    }
    public void ListGoalNames()
    {
        for (int i =0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {   
        string aResponse = "";
        do
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal do you want to create? ");
            aResponse = Console.ReadLine();

        }while (aResponse != "1" && aResponse != "2" && aResponse != "3");
        
        // Console.WriteLine("Please choose a valid input.");

        Console.Write("What is the name of your goal? ");
        string name =Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = Int32.Parse(Console.ReadLine());

        if (aResponse == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (aResponse == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (aResponse == "3")
        {
            int target = 0;
            int bonus = 0;
            Console.Write("How many times do you want to do this goal? ");
            target = Int32.Parse(Console.ReadLine());
            Console.Write("How many points for this? ");
            bonus = Int32.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent()
    {   // will call in each RecordEvent method and use it
        // according to polymorphism logic.
        // call this one into the main program.
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int number = Int32.Parse(Console.ReadLine());

        if (number >= 0 && number < _goals.Count)
        {
            _goals[number].RecordEvent();
            // _score += _goals[number].
        }
        else
        {
            Console.WriteLine("Please choose a valid number");
        }
    }
    public void SaveGoals(string file)
    {
        string filename = "goal.txt";

        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                outputfile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals(string file)
    {
        string filename = "goal.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("/");
        }
    }
}