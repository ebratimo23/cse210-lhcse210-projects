// Lecture.cs
using System;

public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetTypeSpecificDetails()
    {
        return $"Speaker: {speaker}\nCapacity: {capacity} attendees";
    }
}
