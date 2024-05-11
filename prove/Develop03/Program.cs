using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate a new scripture
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        // Display the full scripture
        Console.WriteLine(scripture.GetDisplayText());

        // Wait for user input to start hiding words
        Console.WriteLine("Press Enter to start hiding words or type 'quit' to exit.");
        if (Console.ReadLine().ToLower() == "quit")
            return;

        // Hide words progressively until all are hidden
        while (!scripture.IsCompletelyHidden())
        {
            scripture.HideRandomWords(1);
            Console.WriteLine(scripture.GetDisplayText());

            // Wait for user input to continue or quit
            Console.WriteLine("Press Enter to continue hiding words or type 'quit' to exit.");
            if (Console.ReadLine().ToLower() == "quit")
                break;
        }

        Console.WriteLine("All words hidden. Program ended.");
    }
}
