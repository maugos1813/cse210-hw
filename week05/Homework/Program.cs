using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment tarea = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(tarea.GetSummary());
        Console.WriteLine();

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "1-20");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssingment writing = new WritingAssingment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}