using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // VIDEO 1
        Video v1 = new Video("How to Cook Rice", "Chef John", 300);
        v1.AddComment(new Comment("Alice", "Very helpful!"));
        v1.AddComment(new Comment("Mark", "Thanks, I learned a lot."));
        v1.AddComment(new Comment("Sarah", "Great explanation!"));
        videos.Add(v1);

        // VIDEO 2
        Video v2 = new Video("C# Classes Tutorial", "Code Master", 600);
        v2.AddComment(new Comment("James", "Now I understand classes."));
        v2.AddComment(new Comment("Lily", "Good breakdown."));
        v2.AddComment(new Comment("Tom", "Very clear examples."));
        videos.Add(v2);

        // VIDEO 3
        Video v3 = new Video("Traveling in Japan", "Wander World", 450);
        v3.AddComment(new Comment("Emma", "I want to visit now!"));
        v3.AddComment(new Comment("David", "Beautiful places."));
        v3.AddComment(new Comment("Sophia", "Amazing video!"));
        videos.Add(v3);

        // DISPLAY OUTPUT
        foreach (Video v in videos)
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {v.GetCommentCount()}");
            Console.WriteLine("\nComments:");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"- {c.GetName()}: {c.GetText()}");
            }

            Console.WriteLine("====================================\n");
        }
    }
}