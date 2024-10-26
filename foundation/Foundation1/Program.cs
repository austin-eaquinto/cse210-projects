using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Video v = new Video("Cats", "cats4fun", 55);
        v.AddComments(new Comment("robert", "cute cats"));
        v.AddComments(new Comment("ashley", "love cats"));
        v.AddComments(new Comment("ricardo", "dogs are better"));
        Console.WriteLine(v.DisplayVideoInfo());
        Console.WriteLine($"{v.CommentCount()} comments");
        v.PrintComments();
        Console.WriteLine();

        Video v2 = new Video("Dogs", "dogsRgr8", 120);
        v2.AddComments(new Comment("bill", "best dog I ever had was a mutt"));
        v2.AddComments(new Comment("sarah", "I love dogs!"));
        v2.AddComments(new Comment("friend_of_cats","my cat listens better than these dogs"));
        Console.WriteLine(v2.DisplayVideoInfo());
        Console.WriteLine($"{v2.CommentCount()} comments");
        v2.PrintComments();
        Console.WriteLine();
        
        Video v3 = new Video("Lightning Strikes Building", "n8ure_watcher", 15);
        v3.AddComments(new Comment("greg", "I once had lightning strike the roof of my house. It broke a window!"));
        v3.AddComments(new Comment("susan", "so scary!"));
        v3.AddComments(new Comment("fire_starter", "if only we could make lightning"));
        Console.WriteLine(v3.DisplayVideoInfo());
        Console.WriteLine($"{v3.CommentCount()} comments");
        v3.PrintComments();
        Console.WriteLine();
    }
}