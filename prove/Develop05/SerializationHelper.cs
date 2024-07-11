// SerializationHelper.cs
using System;
using System.IO;
using System.Text.Json;

public static class SerializationHelper
{
    public static void Save<T>(T obj, string filename)
    {
        try
        {
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(filename, jsonString);
            Console.WriteLine($"Object saved successfully to {filename}");
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error saving object: {e.Message}");
        }
    }

    public static T Load<T>(string filename)
    {
        try
        {
            string jsonString = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error loading object: {e.Message}");
            return default(T);
        }
    }
}
