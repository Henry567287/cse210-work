using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements:
        // 1. The program uses a small library of scriptures instead of just one scripture.
        // 2. The program randomly selects one scripture each time it runs.
        // 3. The program hides only words that are still visible.

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding."
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son."
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want."
            )
        };

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        string userInput = "";

        while (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase) &&
               !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            userInput = Console.ReadLine() ?? "";

            if (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                selectedScripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}