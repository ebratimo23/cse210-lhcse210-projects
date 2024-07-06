using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
                BaseActivity activity = null; 
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    break;
            }

            if (activity != null)
            {
                activity.StartActivity();
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

