using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        Activity runningActivity = new Running(new DateTime(2023, 6, 15), 30, 4.8);
        Activity cyclingActivity = new Cycling(new DateTime(2023, 6, 20), 45, 20.5);
        Activity swimmingActivity = new Swimming(new DateTime(2023, 6, 25), 60, 20);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
