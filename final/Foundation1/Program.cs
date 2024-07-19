// Program.cs

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "John Doe", 180);
        video1.AddComment("Alice", "Great introduction!");
        video1.AddComment("Bob", "I learned a lot from this video.");
        video1.AddComment("Charlie", "Could you do more examples?");

        Video video2 = new Video("Object-Oriented Programming Basics", "Jane Smith", 300);
        video2.AddComment("David", "Very clear explanations.");
        video2.AddComment("Eve", "I wish there were subtitles.");

        Video video3 = new Video("ASP.NET Core Basics", "Emily Brown", 240);
        video3.AddComment("Frank", "When will the advanced series be out?");
        video3.AddComment("Grace", "This helped me with my project.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Título: {video.Title}");
            Console.WriteLine($"Autor: {video.Author}");
            Console.WriteLine($"Duración: {video.Length} segundos");
            Console.WriteLine($"Número de comentarios: {video.GetNumberOfComments()}");

            Console.WriteLine("Comentarios:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(); 
        }
    }
}
