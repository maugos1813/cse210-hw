using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Learn C# Basics", "CodeAcademy", 600);
        Video video2 = new Video("OOP in Real Life", "TechWorld", 720);
        Video video3 = new Video("Abstraction Explained", "Dev Simplified", 480);

        video1.Comments.Add(new Comment("Alice", "Great explanation!"));
        video1.Comments.Add(new Comment("Bob", "Helped me understand C# better."));
        video1.Comments.Add(new Comment("Clara", "Thanks for the video!"));

        video2.Comments.Add(new Comment("Daniel", "I loved the real-world examples."));
        video2.Comments.Add(new Comment("Eva", "Very informative."));
        video2.Comments.Add(new Comment("Frank", "Can you make one on inheritance too?"));

        video3.Comments.Add(new Comment("George", "Awesome and short."));
        video3.Comments.Add(new Comment("Hana", "Super clear."));
        video3.Comments.Add(new Comment("Ivan", "You earned a new subscriber!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
