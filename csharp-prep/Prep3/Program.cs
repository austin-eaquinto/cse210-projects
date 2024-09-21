using System;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Prep3 World!"); */

        // these lines creates the random number generator and store it in a variable
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        // creates the guess variable so it's useable
        int guess = 0;
        int amount = 0;

        // start of the while loop that will keep running until the circumstance is satisifed
        while (guess != magicNumber)
        {   
            // part of the while loop so as to come back to it if the guess is wrong
            Console.Write("What is your guess? ");
            // this line allows for user input and turns it into an integer while also storing
            // it in a variable. Very useful. Need to learn this one better.
            guess = int.Parse(Console.ReadLine());
            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            amount = amount + 1;
        }
        Console.Write($"You guessed {amount} time(s).");
        
    }
}

/* Later:
After the game is over, ask the user if they want to play again. Then, loop back 
and play the whole game again and continue this loop as long as they keep saying "yes". */