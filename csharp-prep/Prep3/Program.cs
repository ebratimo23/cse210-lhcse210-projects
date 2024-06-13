using System;

class Program
{
    static void Main(string[] args)
    {
       Random random = new Random();
        int magicNumber = random.Next(1, 101);
        
        bool guessedCorrectly = false;
        while (!guessedCorrectly)
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                guessedCorrectly = true;
            }
        }
    }
}