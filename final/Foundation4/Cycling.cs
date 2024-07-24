using System;

public class Cycling : Activity
{
    private double speed; // in kilometers per hour

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * (minutes / 60.0); // kilometers
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed; // minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Speed: {speed:F2} kph";
    }
}
