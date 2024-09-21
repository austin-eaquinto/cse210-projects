using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        // This creates a new list
        List<int> numbers = new List<int>();
        
        //  can't have the number start with 0 or the loop would
        //  be over immediately.
        int userNumber = -1;
        
        // the loop for storing user input in the list
        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // this is the specific section that adds to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum} ");

        // creates a float variable for division to find the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        int max = numbers[0];

        // finds the biggest number from the entered numbers
        // and prints it
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}

/* Later:
Have the user enter both positive and negative numbers, then find 
the smallest positive number (the positive number that is closest 
to zero).

Sort the numbers in the list and display the new, sorted list. 
Hint: There are C# libraries that can help you here, try searching 
the internet for them. 
*/