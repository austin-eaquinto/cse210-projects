using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        string first = a1.GetSummary();
        Console.WriteLine(first);

        MathAssignment ma1 = new MathAssignment("Riberto Rodriguez", "Fractions", "7.3", "8-19");
        string math = ma1.GetSummary();
        string math2 = ma1.GetHomeworkList();
        Console.WriteLine(math);
        Console.WriteLine(math2);

        WritingAssignment wa1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string write = wa1.GetSummary();
        string write2 = wa1.GetWritingInformation();
        Console.WriteLine(write);
        Console.WriteLine(write2);
    }
}