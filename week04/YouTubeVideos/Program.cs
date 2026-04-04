using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Build a Gaming PC", "TechZone", 720);
        video1.AddComment(new Comment("Lucas", "This was super helpful!"));
        video1.AddComment(new Comment("Amanda", "Best tutorial I found."));
        video1.AddComment(new Comment("Ryan", "You explained it really well."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Soccer Goals", "SportsHub", 540);
        video2.AddComment(new Comment("Carlos", "That bicycle kick was insane."));
        video2.AddComment(new Comment("Emily", "Messi is just different."));
        video2.AddComment(new Comment("Jordan", "I’ve watched this 3 times already."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Easy Brazilian Recipes", "Cooking with Ana", 630);
        video3.AddComment(new Comment("Sophia", "I want to try this at home."));
        video3.AddComment(new Comment("Mateus", "That looks just like my mom’s food."));
        video3.AddComment(new Comment("Olivia", "Now I’m hungry."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Beginner C# Tutorial", "CodeMaster", 900);
        video4.AddComment(new Comment("David", "This helped me understand classes better."));
        video4.AddComment(new Comment("Emma", "Thanks for making it simple."));
        video4.AddComment(new Comment("Noah", "Can you make a part 2?"));
        videos.Add(video4);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
