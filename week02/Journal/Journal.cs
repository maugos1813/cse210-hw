using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private readonly List<Entry> _entries = new();
    private readonly List<string> _prompts = new()
    {
        "¿Quién fue la persona más interesante con la que interactuaste hoy?",
        "¿Cuál fue la mejor parte de tu día?",
        "¿Cómo viste la mano de Dios en tu vida hoy?",
        "¿Qué emoción fue la más intensa que sentiste hoy?",
        "Si pudieras repetir algo de hoy, ¿qué sería?"
    };

    private readonly Random _rng = new();

    public void AddEntry()
    {
        string prompt = _prompts[_rng.Next(_prompts.Count)];
        Console.WriteLine($"\nPREGUNTA: {prompt}");
        Console.Write("Tu respuesta: ");
        string response = Console.ReadLine() ?? "";
        _entries.Add(new Entry(DateTime.Now, prompt, response));
        Console.WriteLine("✓ Entrada guardada en memoria.\n");
    }

    public void Display()
    {
        Console.WriteLine("\n--- Diario ---");
        if (_entries.Count == 0)
        {
            Console.WriteLine("No hay entradas todavía.\n");
            return;
        }

        foreach (Entry e in _entries)
        {
            Console.WriteLine(e);
        }
    }

    public void SaveToFile()
    {
        Console.Write("Introduce nombre de archivo para guardar (ej. diario.txt): ");
        string filename = Console.ReadLine() ?? "diario.txt";

        using StreamWriter writer = new(filename);
        foreach (Entry e in _entries)
            writer.WriteLine(e.ToFileString());

        Console.WriteLine($"✓ Diario guardado en {filename}\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Archivo a cargar: ");
        string filename = Console.ReadLine() ?? "";

        if (!File.Exists(filename))
        {
            Console.WriteLine("✗ Ese archivo no existe.\n");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
            _entries.Add(Entry.FromFileString(line));

        Console.WriteLine($"✓ {lines.Length} entradas cargadas.\n");
    }
}
