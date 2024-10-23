using System;
using System.Diagnostics;

class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        // List<string> _prompts = new List<string>();
        this._prompts.Add("Who are people that you appreciate?");
        this._prompts.Add("What are personal strengths of yours?");
        this._prompts.Add("Who are people that you have helped this week?");
        this._prompts.Add("When have you felt the Holy Ghost this month?");
        this._prompts.Add("Who are some of your personal heroes?");
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int promptsList = random.Next(this._prompts.Count());
        return _prompts[promptsList];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
    }
    public string GetListFromUser()
    {
        return Console.ReadLine();
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetTime();
        Console.Clear();
        Console.WriteLine("Getting Ready...");
        ShowSpinner(SpinnerTime());
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt.");
        DisplayPrompt();
        // Console.WriteLine("Press enter when you are ready to begin.");
        // Console.ReadLine();

        Console.Write("You may begin in... ");
        ShowCountDown(10);

        Stopwatch stopwatch = Stopwatch.StartNew();

        List<string> userList = new List<string>();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            this._count++;
            userList.Add(GetListFromUser());
        }
        stopwatch.Stop();
        DisplayEndingMessage();
        // display number of items user entered
        Console.WriteLine("You listed "+ this._count + " items.");
        ShowSpinner(4);
        Console.Clear();
    }
}