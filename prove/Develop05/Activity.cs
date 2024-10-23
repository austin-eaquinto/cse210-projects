using System;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    public Activity(string name, string description/*, int duration*/)
    {
        _name = name;
        _description = description;
        // _duration = duration;
    }
    public void GetTime()
    {
        Console.Write("How long in seconds would you like for your session? ");
        string response = Console.ReadLine();
        SetTime(response);
    }
    public void SetTime(string response)
    {
        int duration;

        if (int.TryParse(response, out duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 10 seconds.");
            _duration = 10;
        }
    }
    public int SpinnerTime()
    {
        int time = 5;
        return time;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void DisplayEndingMessage()
    {
        Thread.Sleep(1500);
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {   
    // the spinner list. it has to be inside the method to work
    List<string> animationString = new List<string>();
    animationString.Add("|");
    animationString.Add("/");
    animationString.Add("-");
    animationString.Add("\\");
    animationString.Add("|");
    animationString.Add("/");
    animationString.Add("-");
    animationString.Add("\\");

    // parameters for the timer. it will run from 'now' to ten seconds later
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        // initializes i
        int i = 0;

        // this loop will go for ten seconds as set above
        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            // picks the next index to start from once the loop starts over
            i++;

            // in the list of 8 items, this resets i to 0 so that the loop
            // will continue for ten seconds, instead of ending with the list.
            if (i >= animationString.Count)
            {
                i = 0;
            }

        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        // Console.WriteLine("Well done!");
    }
}