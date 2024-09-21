using System;

class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Prep2 World!"); */
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int percentage = int.Parse(grade);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
            /* Console.WriteLine("You have an 'A'."); */
        }
        else if (percentage >= 80)
        {
            letter ="B";
            /* Console.WriteLine("You have a 'B'."); */
        }
        else if (percentage >= 70)
        {
            letter = "C";
            /* Console.WriteLine("You have a 'C'."); */
        }
        else if (percentage >= 60)
        {
            letter = "D";
            /* Console.WriteLine("You have a 'D'."); */
        }
        else /* (grade < 60) */
        {
            letter = "F";
            /* Console.WriteLine("You have an 'F'."); */
        }

        Console.Write($"Your grade is: {letter}");

        int remainder = percentage / 10;
        if (remainder >= 7)
        {
            Console.WriteLine("+.");
        }
        else if (remainder < 3)
        {
            Console.WriteLine("-.");
        }

        

        if (percentage >= 70)
        {
            Console.Write("You passed the class! ");
        }
        else
        {
            Console.Write("You will have to take the class again. ");
        }

        /* Later:
            Recognize that there is no A+ grade, only A and A-. Add some additional logic to your program to detect 
            this case and handle it correctly.

            Similarly, recognize that there is no F+ or F- grades, only F. Add additional logic to your program to 
            detect these cases and handle them correctly. 
        */

    }
}