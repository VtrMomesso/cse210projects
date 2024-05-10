using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Save Entries to File");
            Console.WriteLine("4. Load Entries from File");
            Console.WriteLine("5. Get Random Prompt");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter your choice:");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter date:");
                    string date = Console.ReadLine();
                    Console.WriteLine("Enter prompt text:");
                    string promptText = Console.ReadLine();
                    Console.WriteLine("Enter entry text:");
                    string entryText = Console.ReadLine();
                    myJournal.AddEntry(new Entry(date, promptText, entryText));
                    break;
                case 2:
                    myJournal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("Enter file name to save entries:");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    break;
                case 4:
                    Console.WriteLine("Enter file name to load entries:");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    break;
                case 5:
                    Console.WriteLine(promptGenerator.GetRandomPrompt());
                    break;
                case 6:
                    Console.WriteLine("Exiting program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}
