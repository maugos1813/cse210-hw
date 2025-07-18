/// EXTRA FEATURE:
/// This program randomly selects one scripture from a list of scripture entries.
/// Each entry contains a reference (e.g., "John 3:16") and a scripture text.
/// This allows users to practice memorizing different scriptures, not just one hardcoded verse.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> scriptures = new List<string>()
        {
            "John 3:16|For God so loved the world that he gave his only begotten Son",
            "Proverbs 3:5-6|Trust in the Lord with all thine heart and lean not unto thine own understanding",
            "Psalm 23:1|The Lord is my shepherd I shall not want",
            "2 Nephi 2:25|Adam fell that men might be and men are that they might have joy"
        };

        Random rand = new Random();
        string selected = scriptures[rand.Next(scriptures.Count)];


        string[] parts = selected.Split('|');
        string referencePart = parts[0];
        string verseText = parts[1];

        string book = referencePart.Split(' ')[0];
        string chapterVerse = referencePart.Split(' ')[1];
        int chapter = int.Parse(chapterVerse.Split(':')[0]);

        string versePart = chapterVerse.Split(':')[1];
        Reference reference;

        if (versePart.Contains("-"))
        {
            int startVerse = int.Parse(versePart.Split('-')[0]);
            int endVerse = int.Parse(versePart.Split('-')[1]);
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            int verse = int.Parse(versePart);
            reference = new Reference(book, chapter, verse);
        }

        Scripture scripture = new Scripture(reference, verseText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will now exit.");
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
