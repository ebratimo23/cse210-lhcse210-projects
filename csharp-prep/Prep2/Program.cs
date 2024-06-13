using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        double percentage = double.Parse(Console.ReadLine());

        string letterGrade;
        if(percentage >= 90)
        {
            letterGrade = "A";
        }
        else if(percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60){
            letterGrade = "D";
        }
        else{
            letterGrade = "F";
        }

        bool passed = percentage >= 70;

        Console.WriteLine($"Your letter grade is {letterGrade}.");

        if(passed){
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else{
            Console.WriteLine("Keep working hard! You'll get it next time");
        }
    }

}