using System;
using System.Diagnostics;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(/*string name, string description, int duration*/) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on breathing.") 
    {

    }
    //     public void ShowBreatherIn(int seconds)
    // {   
    // // the breather list. it has to be inside the method to work.
    // List<string> breatherStringIn = new List<string>();
    // breatherStringIn.Add(".");
    // breatherStringIn.Add("..");
    // breatherStringIn.Add("...");
    // breatherStringIn.Add("....");
    // breatherStringIn.Add(".....");
    // breatherStringIn.Add("......");
    // breatherStringIn.Add(".......");
    // breatherStringIn.Add("........");

    // // parameters for the timer. it will run from 'now' to ten seconds later
    //     DateTime startTime = DateTime.Now;
    //     DateTime endTime = startTime.AddSeconds(seconds);

    //     // initializes i
    //     int i = 0;

    //     // this loop will go for ten seconds as set above
    //     while (DateTime.Now < endTime)
    //     {
    //         string s = breatherStringIn[i];
    //         Console.Write(s);
    //         Thread.Sleep(100);
    //         Console.Write("\b \b");

    //         // picks the next index to start from once the loop starts over
    //         i++;

    //         // in the list of 8 items, this resets i to 0 so that the loop
    //         // will continue for ten seconds, instead of ending with the list.
    //         if (i >= breatherStringIn.Count)
    //         {
    //             i = 0;
    //         }

    //     }
    // }
    //         public void ShowBreatherOut(int seconds)
    // {   
    // // the breather list. it has to be inside the method to work.
    // List<string> breatherStringOut = new List<string>();
    // breatherStringOut.Add("........");
    // breatherStringOut.Add(".......");
    // breatherStringOut.Add("......");
    // breatherStringOut.Add(".....");
    // breatherStringOut.Add("....");
    // breatherStringOut.Add("...");
    // breatherStringOut.Add("..");
    // breatherStringOut.Add(".");

    // // parameters for the timer. it will run from 'now' to ten seconds later
    //     DateTime startTime = DateTime.Now;
    //     DateTime endTime = startTime.AddSeconds(seconds);

    //     // initializes i
    //     int i = 0;

    //     // this loop will go for ten seconds as set above
    //     while (DateTime.Now < endTime)
    //     {
    //         string s = breatherStringOut[i];
    //         Console.Write(s);
    //         Thread.Sleep(500);
    //         Console.Write("\b \b");

    //         // picks the next index to start from once the loop starts over
    //         i++;

    //         // in the list of 8 items, this resets i to 0 so that the loop
    //         // will continue for ten seconds, instead of ending with the list.
    //         if (i >= breatherStringOut.Count)
    //         {
    //             i = 0;
    //         }

    //     }
    // }
    public void Run()
    {
        DisplayStartingMessage();
        GetTime();
        // SetTime();
        Console.Clear();
        Console.WriteLine("Getting Ready...");
        ShowSpinner(SpinnerTime());
        Console.WriteLine();

        Stopwatch stopwatch = Stopwatch.StartNew();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
        Console.Write("Breathe in... ");
        // ShowBreatherIn(4);
        ShowCountDown(4);
        Console.Write("Now breathe out...");
        ShowCountDown(6);
        Console.WriteLine();
        }
        stopwatch.Stop();
        DisplayEndingMessage();
        ShowSpinner(4);
        Console.Clear();
    }
}