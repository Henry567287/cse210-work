using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Video 1
        Video video1 = new Video("Music Basics", "Henrico", 50);
        video1.AddComment(new Comment("Alice", "Great lesson!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));

        // Create Video 2
        Video video2 = new Video("Piano Practice", "Sarah", 42);
        video2.AddComment(new Comment("David", "Nice tutorial."));
        video2.AddComment(new Comment("Eva", "Clear explanation."));
        video2.AddComment(new Comment("Frank", "Thanks for this!"));

        // Create Video 3
        Video video3 = new Video("Guitar Chords", "Mike", 36);
        video3.AddComment(new Comment("Grace", "Awesome content!"));
        video3.AddComment(new Comment("Henry", "Very easy to follow."));
        video3.AddComment(new Comment("Ivy", "Loved it!"));

        // Store videos in a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}