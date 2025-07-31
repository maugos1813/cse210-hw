using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int interval = 6; // 3 in + 3 out
        int rounds = duration / interval;

        for (int i = 0; i < rounds; i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(3);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
