using System;
using System.Diagnostics;
using System.Threading;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = ["Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."];

        _questions = ["Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experienc that applies to other situations?", 
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"];

    }
    public int GetPromptList()
    {
        Random random = new Random();
        int promptList = random.Next(_prompts.Count());
        return promptList;
    }
    public string GetRandomPrompt()
    {
        int promptList = GetPromptList();
        return _prompts[promptList];
    }
    public int GetQuestionList()
    {
        Random random = new Random();
        int questionList = random.Next(_questions.Count());
        return questionList;
    }
    public string GetRandomQuestion()
    {
        int questionList = GetQuestionList();
        return _questions[questionList];
    }
    public void DisplayPrompt(int promptList)
    {
        Console.WriteLine($"--- {_prompts[promptList]} ---");
    }
    public void DisplayQuestions(int questionList)
    {
        Console.WriteLine(_questions[questionList]);
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetTime();
        Console.Clear();
        Console.WriteLine("Getting Ready...");
        ShowSpinner(SpinnerTime());
        Console.WriteLine();
        DisplayPrompt(GetPromptList());
        Console.WriteLine("When you have something in mind press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Stopwatch stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            DisplayQuestions(GetQuestionList());
            ShowSpinner(6);
            // Console.ReadLine();
        }
        stopwatch.Stop();
        DisplayEndingMessage();
        ShowSpinner(4);
        Console.Clear();
    }
}

/*
.Pop
copy the list, pop things out and once it's empty
it pulls back from the main list again.
*/