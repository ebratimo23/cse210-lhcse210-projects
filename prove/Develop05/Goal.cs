// Goal.cs
using System;

[Serializable]
public class Goal
{
    protected internal string name;
    protected internal bool isCompleted;
    protected internal int currentProgress;
    protected internal int targetProgress;
    protected internal int pointsPerCompletion;
    protected internal int bonusPoints;

    public Goal(string name, int targetProgress, int pointsPerCompletion, int bonusPoints = 0)
    {
        this.name = name;
        this.isCompleted = false;
        this.currentProgress = 0;
        this.targetProgress = targetProgress;
        this.pointsPerCompletion = pointsPerCompletion;
        this.bonusPoints = bonusPoints;
    }

    public virtual void MarkComplete()
    {
        isCompleted = true;
    }

    public virtual void RecordProgress()
    {
        currentProgress++;
        if (currentProgress >= targetProgress)
        {
            MarkComplete();
        }
    }

    public virtual void DisplayProgress()
    {
        string status = isCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {name}");
    }

    public override string ToString()
    {
        return name;
    }
}

[Serializable]
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points)
        : base(name, 1, points)
    {
    }
}

[Serializable]
public class EternalGoal : Goal
{
    public EternalGoal(string name, int pointsPerCompletion)
        : base(name, int.MaxValue, pointsPerCompletion)
    {
    }
}

[Serializable]
public class ChecklistGoal : Goal
{
    public ChecklistGoal(string name, int targetProgress, int pointsPerCompletion, int bonusPoints)
        : base(name, targetProgress, pointsPerCompletion, bonusPoints)
    {
    }

    public override void MarkComplete()
    {
        base.MarkComplete();
        Console.WriteLine($"Bonus {bonusPoints} points earned for completing {name}!");
    }

    public override void DisplayProgress()
    {
        string status = isCompleted ? $"Completed {currentProgress}/{targetProgress} times" : $"[ ] {name}";
        Console.WriteLine(status);
    }
}
