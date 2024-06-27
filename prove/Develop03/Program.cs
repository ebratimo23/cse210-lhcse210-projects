using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        BibleManager bibleManager = new BibleManager();
        var scripture = bibleManager.GetRandomScripture();

        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
        Console.WriteLine();

        int wordCount = CountWords(scripture.Text);
        List<string> hiddenWords = new List<string>();

        while (hiddenWords.Count < wordCount)
        {
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                return;

            HideRandomWord(scripture.Text, hiddenWords);
            Console.Clear();
            DisplayScripture(scripture, hiddenWords);
        }

        Console.WriteLine("You have hidden all words from the scripture!");
    }

    static void DisplayScripture(Scripture scripture, List<string> hiddenWords)
    {
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
        Console.WriteLine();

        string[] words = scripture.Text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (hiddenWords.Contains(words[i]))
                Console.Write("***** ");
            else
                Console.Write($"{words[i]} ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(scripture.Reference.ToString()); // Only display the scripture reference
    }

    static void HideRandomWord(string text, List<string> hiddenWords)
    {
        string[] words = text.Split(' ');
        Random random = new Random();
        int index = random.Next(words.Length);
        hiddenWords.Add(words[index]);
    }

    static int CountWords(string text)
    {
        return text.Split(' ').Length;
    }
}
