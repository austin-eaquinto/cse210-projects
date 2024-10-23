using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Video v = new Video();
        v._title = "Cats";
        v._author = "cats4fun";
        v._length = 55;
        Comment c = new Comment();
        c._name = "robert";

        Console.WriteLine(v.DisplayVideoInfo());
        v.AddComments("a comment");
        v.AddComments("second comment");
        v.AddComments("third comment");
        v.CommentCount();
        v.PrintComments();
        v.GetComments();
        Console.WriteLine($"{v.CommentCount()} comments")

        Video v2 = new Video();
        v2._title = "title";
        v2._author = "author";
        v2._length = 55;
        Comment c2 = new Comment();
        c2._name = "robert";

        Console.WriteLine(v2.DisplayVideoInfo());
        v2.AddComments("a comment");
        v2.AddComments("second comment");
        v2.AddComments("third comment");
        v2.CommentCount();
        v2.PrintComments();
        Console.WriteLine($"{v2.ComommentCount} comments");
    }
}
/* Once you have the classes in place, write a program 
that creates 3-4 videos, sets the appropriate values, 
and for each one add a list of 3-4 comments (with the 
commenter's name and text). Put each of these videos in 
a list.

Then, have your program iterate through the list of videos 
and for each one, display the title, author, length, number 
of comments (from the method) and then list out all of the 
comments for that video. Repeat this display for each video 
in the list. */