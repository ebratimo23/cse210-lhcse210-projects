using System;
using System.Threading;

public abstract class BaseActivity
{
    protected int durationInSeconds;
    protected string name;
    protected string description;

    public BaseActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public abstract void StartActivity();

    protected void ShowMessageWithDelay(string message, int delayInSeconds)
    {
        Console.WriteLine(message);
        Thread.Sleep(delayInSeconds * 1000);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
