using System;
using System.Collections.Generic;
using System.Threading;

public class GratitudeActivity : Activity
{
    public GratitudeActivity() 
        : base("Gratitude", "This activity will help you reflect on the good things in your life by writing down what you are grateful for.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        List<string> gratitudes = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Write something you're grateful for: ");
            string input = Console.ReadLine();
            gratitudes.Add(input);
            Console.WriteLine();
        }

        Console.WriteLine("\nWell done! Here's what you were grateful for:");
        foreach (string gratitude in gratitudes)
        {
            Console.WriteLine($"- {gratitude}");
        }

        DisplayEndingMessage();
    }
}
