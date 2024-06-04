// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author1", 300);
        Video video2 = new Video("Video 2", "Author2", 450);
        Video video3 = new Video("Video 3", "Author3", 600);

        // Add comments to videos
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Nice content."));

        video2.AddComment(new Comment("User3", "Very informative."));
        video2.AddComment(new Comment("User4", "Loved it!"));
        video2.AddComment(new Comment("User5", "Thanks for sharing."));

        video3.AddComment(new Comment("User6", "Amazing work!"));
        video3.AddComment(new Comment("User7", "Super helpful."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
