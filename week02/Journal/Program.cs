// This file was updated to support an additional menu option (#6)
// that allows users to export the journal to a .CSV file using the new SaveAsCsv() method.
// This enhancement exceeds the basic requirements by improving usability and file compatibility.

using System;

class Program
{
    static void Main()
    {
        Journal journal = new();
        bool running = true;

        while (running)
        {
            Console.WriteLine("--------- MENU ---------");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Save journal in CSV format"); // NEW OPTION
            Console.Write("Choose an option (1‑6): ");

            string choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1": journal.AddEntry();       break;
                case "2": journal.Display();        break;
                case "3": journal.SaveToFile();     break;
                case "4": journal.LoadFromFile();   break;
                case "5": running = false;          break;
                case "6": journal.SaveAsCsv();      break; // NEW CASE
                default:  Console.WriteLine("Invalid option.\n"); break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
