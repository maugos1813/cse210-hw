// This file was updated to include the ability to export journal entries as a .CSV file.
// The new SaveAsCsv() method writes entries to a file with column headers and properly escaped fields,
// allowing easy import into Excel or other spreadsheet tools.

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private readonly List<Entry> _entries = new();
    private readonly List<string> _prompts = new()
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of God in your life today?",
        "What was the strongest emotion you felt today?",
        "If you could repeat something from today, what would it be?"
    };

    private readonly Random _rng = new();

    public void AddEntry()
    {
        string prompt = _prompts[_rng.Next(_prompts.Count)];
        Console.WriteLine($"\nPROMPT: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine() ?? "";
        _entries.Add(new Entry(DateTime.Now, prompt, response));
        Console.WriteLine("✓ Entry added to memory.\n");
    }

    public void Display()
    {
        Console.WriteLine("\n--- Journal ---");
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
            return;
        }

        foreach (Entry e in _entries)
        {
            Console.WriteLine(e);
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter file name to save (e.g. journal.txt): ");
        string filename = Console.ReadLine() ?? "journal.txt";

        using StreamWriter writer = new(filename);
        foreach (Entry e in _entries)
            writer.WriteLine(e.ToFileString());

        Console.WriteLine($"✓ Journal saved to {filename}\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter file name to load: ");
        string filename = Console.ReadLine() ?? "";

        if (!File.Exists(filename))
        {
            Console.WriteLine("✗ File does not exist.\n");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
            _entries.Add(Entry.FromFileString(line));

        Console.WriteLine($"✓ {lines.Length} entries loaded.\n");
    }

    // NEW: Save journal entries to a CSV file
    public void SaveAsCsv()
    {
        Console.Write("Enter file name for CSV (e.g. journal.csv): ");
        string filename = Console.ReadLine() ?? "journal.csv";

        using StreamWriter writer = new(filename);
        writer.WriteLine("Date,Prompt,Response"); // CSV header
        foreach (Entry e in _entries)
            writer.WriteLine(e.ToCsvString());

        Console.WriteLine($"✓ Journal saved in CSV format: {filename}\n");
    }
}
