using System;

public class Running : Activity
{
    private double distance; // in kilometers

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (minutes / 60.0); // kilometers per hour
    }

    public override double GetPace()
    {
        return minutes / distance; // minutes per kilometer
    }
}
