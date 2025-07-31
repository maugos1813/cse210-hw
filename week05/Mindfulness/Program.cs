// Program.cs:
// This console application guides the user through a variety of mindfulness activities.
// Activities include Breathing, Listing, Reflection, and Gratitude.
// 
// The Gratitude Activity helps users reflect on the positive aspects of their life
// by allowing them to write down things they are grateful for.
// It promotes mental well-being and a positive mindset.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
{
    case "1":
        BreathingActivity breathing = new BreathingActivity();
        breathing.Run();
        break;
    case "2":
        ListingActivity listing = new ListingActivity();
        listing.Run();
        break;
    case "3":
        ReflectingActivity reflection = new ReflectingActivity();
        reflection.Run();
        break;
    case "4":
        GratitudeActivity gratitude = new GratitudeActivity();
        gratitude.Run();
        break;
    case "5":
        Console.WriteLine("Goodbye!");
        return;
    default:
        Console.WriteLine("Invalid option. Please try again.");
        break;
}

        }
    }
}
