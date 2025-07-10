using System;

public class Entry
{
    public DateTime Date { get; }
    public string Prompt { get; }
    public string Response { get; }

    public Entry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public string ToFileString()
    {
        return $"{Date:yyyy-MM-dd  HH:mm}|{Prompt}|{Response}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split("|", 3);
        DateTime date = DateTime.Parse(parts[0]);
        string prompt = parts[1];
        string response = parts[2];
        return new Entry(date, prompt, response);
    }

    public override string ToString()
    {
        return $"[{Date:yyyy-MM-dd}] {Prompt}\n  → {Response}\n";
    }
}