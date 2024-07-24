// Program.cs
using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Park Ave", "Sometown", "NY", "54321");

        Lecture lecture = new Lecture("Public Speaking Mastery", "Learn the art of public speaking from experts", new DateTime(2024, 8, 15), "10:00 AM", address1, "John Doe", 50);

        Reception reception = new Reception("Networking Mixer", "A networking event for professionals", new DateTime(2024, 9, 1), "6:00 PM", address2, "rsvp@example.com");

        OutdoorGathering gathering = new OutdoorGathering("Summer Picnic", "Enjoy a day of fun and food outdoors", new DateTime(2024, 7, 30), "12:00 PM", address1, "Sunny with a chance of clouds");

        Console.WriteLine("===== Lecture Event =====");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("\n");

        Console.WriteLine("===== Reception Event =====");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\n");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("\n");

        Console.WriteLine("===== Outdoor Gathering Event =====");
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine("\n");
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine("\n");
        Console.WriteLine(gathering.GetShortDescription());
    }
}
