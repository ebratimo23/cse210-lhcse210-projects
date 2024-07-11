// Program.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        User user = new User("JohnDoe");

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("\nEternal Quest - Menu:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nEnter your choice (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();
                    Console.Write("Enter goal type (simple/eternal/checklist): ");
                    string goalType = Console.ReadLine().ToLower();
                    if (goalType == "checklist")
                    {
                        Console.Write("Enter target progress: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Enter points per completion: ");
                        int points = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        user.CreateGoal(goalName, goalType, target, points, bonus);
                    }
                    else
                    {
                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());
                        user.CreateGoal(goalName, goalType, points: points);
                    }
                    break;
                case "2":
                    user.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    user.Save(saveFile);
                    break;
                case "4":
                    Console.Write("Enter filename to load goals: ");
                    string loadFile = Console.ReadLine();
                    User loadedUser = SerializationHelper.Load<User>(loadFile);
                    if (loadedUser != null)
                    {
                        user = loadedUser;
                        Console.WriteLine("Goals loaded successfully.");
                    }
                    break;
                case "5":
                    Console.Write("Enter goal name to record event: ");
                    string eventGoal = Console.ReadLine();
                    user.RecordEvent(eventGoal);
                    Console.WriteLine($"Event recorded for {eventGoal}");
                    break;
                case "6":
                    quit = true;
                    Console.WriteLine("Exiting Eternal Quest.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }
}
