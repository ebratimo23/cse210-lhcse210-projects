using System;
using System.Threading;

public class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base("Breathing Activity", "Helps you relax by focusing on your breathing.")
    {
    }

    public override void StartActivity()
    {
        ShowMessageWithDelay($"{name}: {description}", 2);
        Console.WriteLine("Enter duration in seconds:");
        durationInSeconds = Convert.ToInt32(Console.ReadLine());

        ShowMessageWithDelay("Get ready to begin...", 2);

        int breatheCycleDuration = 4; // 4 seconds for each breathe in/out
        int cycles = durationInSeconds / breatheCycleDuration;

        for (int i = 0; i < cycles; i++)
        {
            ShowMessageWithDelay("Breathe in...", 2);
            ShowCountdown(breatheCycleDuration);

            if (i < cycles - 1) // only show "Breathe out..." if not the last cycle
            {
                ShowMessageWithDelay("Breathe out...", 2);
                ShowCountdown(breatheCycleDuration);
            }
        }

        ShowMessageWithDelay("Well done! You've completed the Breathing Activity.", 2);
        ShowMessageWithDelay($"Duration: {durationInSeconds} seconds", 2);
    }
}

public class ReflectionActivity : BaseActivity
{
    private string[] reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "Reflects on times of strength and resilience.")
    {
    }

    public override void StartActivity()
    {
        ShowMessageWithDelay($"{name}: {description}", 2);
        Console.WriteLine("Enter duration in seconds:");
        durationInSeconds = Convert.ToInt32(Console.ReadLine());

        ShowMessageWithDelay("Get ready to begin...", 2);

        Random rand = new Random();

        int elapsedTime = 0;
        while (elapsedTime < durationInSeconds)
        {
            string prompt = reflectionPrompts[rand.Next(reflectionPrompts.Length)];
            ShowMessageWithDelay(prompt, 2);

            foreach (string question in reflectionQuestions)
            {
                ShowMessageWithDelay(question, 2);
            }

            elapsedTime += reflectionQuestions.Length * 2 + 2; // each question takes 2 seconds
        }

        ShowMessageWithDelay("Well done! You've completed the Reflection Activity.", 2);
        ShowMessageWithDelay($"Duration: {durationInSeconds} seconds", 2);
    }
}

public class ListingActivity : BaseActivity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "Lists positive aspects or strengths.")
    {
    }

    public override void StartActivity()
    {
        ShowMessageWithDelay($"{name}: {description}", 2);
        Console.WriteLine("Enter duration in seconds:");
        durationInSeconds = Convert.ToInt32(Console.ReadLine());

        ShowMessageWithDelay("Get ready to begin...", 2);
        ShowMessageWithDelay(listingPrompts[0], 2);

        int elapsedTime = 0;
        int itemsListed = 0;
        while (elapsedTime < durationInSeconds)
        {
            itemsListed++;
            elapsedTime += 2; // each item takes 2 seconds
            if (elapsedTime < durationInSeconds)
            {
                ShowMessageWithDelay("List another item...", 2);
            }
        }

        ShowMessageWithDelay($"You listed {itemsListed} items.", 2);
        ShowMessageWithDelay("Well done! You've completed the Listing Activity.", 2);
        ShowMessageWithDelay($"Duration: {durationInSeconds} seconds", 2);
    }
}
