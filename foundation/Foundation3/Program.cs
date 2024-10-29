using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        // creates a list of the activity class
        // uses polymorphism to access the subclass info
        {
            // each one calls a subclass and fills the required parameters
            // duration, distance, time
            new RunningActivity(30, 3.0, 25),
            // duration, speed, time
            new BikingActivity(45, 15, 30),
            // duration, lap amount, time
            new SwimmingActivity(30, 20, 60)
        };
        foreach (Activity activity in activities)
        // iterates through each activity above and
        // prints it. 
        {
            Console.WriteLine(activity.GetSummary());
            // the .GetSummary() pulls each subclass GetSummary()
            // according to polymorphism. 
        }
    }
}