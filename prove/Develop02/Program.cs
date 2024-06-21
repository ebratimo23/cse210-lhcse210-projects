using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date};{entry.Prompt};{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];
                    Entry entry = new Entry(date, prompt, response);
                    entries.Add(entry);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading file: {e.Message}");
        }
    }
}

class Program
{
    private static Journal journal = new Journal();

    static void Main(string[] args)
    {
        string choice;
        do
        {
            DisplayMenu();
            choice = Console.ReadLine().Trim();
            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != "5");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n=== Menu ===");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
    }

    static void WriteNewEntry()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        string randomPrompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Response: ");
        string response = Console.ReadLine();
        DateTime date = DateTime.Now;
        Entry entry = new Entry(date, randomPrompt, response);
        journal.AddEntry(entry);
        Console.WriteLine("Entry added successfully.");
    }

    static void DisplayJournal()
    {
        Console.WriteLine("\n=== Journal Entries ===");
        journal.DisplayEntries();
    }

    static void SaveJournal()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine().Trim();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved to file successfully.");
    }

    static void LoadJournal()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine().Trim();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded from file successfully.");
    }
}
