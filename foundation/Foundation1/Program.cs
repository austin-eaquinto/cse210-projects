using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Comment c1 = new Comment();
        // c1._name = "bill";
        // c1._text = "a short comment";
        // c1.GatherComments();

        Video v1 = new Video();
        v1._title = "First Video";
        v1._author = "Aaron Anderson";
        v1._length = 5;
        v1._commentAmount = 2;
        v1._comment = new List<Comment>();
        v1._comment.Add(c1);

        Video v2 = new Video();
        Video v3 = new Video();
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