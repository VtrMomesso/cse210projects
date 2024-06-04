using System;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Sydney", "NSW", "Australia");

        // Create events
        Lecture lecture = new Lecture("Tech Talk", "An in-depth look at AI", "12/12/2024", "10:00 AM", address1, "John Smith", 100);
        Reception reception = new Reception("Networking Event", "Meet and greet with industry professionals", "15/12/2024", "6:00 PM", address2, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "A fun day in the park", "20/12/2024", "1:00 PM", address3, "Sunny");

        // Display event details
        DisplayEventDetails(lecture);
        DisplayEventDetails(reception);
        DisplayEventDetails(outdoorGathering);
    }

    static void DisplayEventDetails(Event event)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(event.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(event.GetShortDescription());
        Console.WriteLine("============================================\n");
    }
}
