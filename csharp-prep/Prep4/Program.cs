using System;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;
        int max = int.MinValue; 
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
                break;
            
            sum += input;
            count++;
            if (input > max)
                max = input;
        }
        
        double average = (double)sum / count;
        
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }
}