// User.cs
using System;
using System.Collections.Generic;

[Serializable]
public class User
{
    private string username;
    private int score;
    private List<Goal> goals;

    public User(string username)
    {
        this.username = username;
        this.score = 0;
        this.goals = new List<Goal>();
    }

    public void CreateGoal(string name, string type, int target = 1, int points = 0, int bonus = 0)
    {
        Goal goal;
        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, points);
                break;
            case "checklist":
                goal = new ChecklistGoal(name, target, points, bonus);
                break;
            default:
                throw new ArgumentException("Invalid goal type.");
        }
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.ToString() == goalName);
        if (goal != null)
        {
            goal.RecordProgress();
            score += goal.pointsPerCompletion;
            if (goal.isCompleted && goal.bonusPoints > 0)
            {
                score += goal.bonusPoints;
            }
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"Current goals for {username}:");
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }
        Console.WriteLine($"Total Score: {score}");
    }

    // Save and Load methods using JSON serialization
    public void Save(string filename)
    {
        SerializationHelper.Save<User>(this, filename);
    }

    public static User Load(string filename)
    {
        return SerializationHelper.Load<User>(filename);
    }
}
