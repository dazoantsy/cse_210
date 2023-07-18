using System;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video ("Video 1", "Author 1", 125);
        Comment comment1 = new Comment ("User 1", "Comment 1");
        video1.AddComment(comment1.GetCommentDetails());
        Comment comment2 = new Comment ("User 2", "Comment 2");
        video1.AddComment(comment2.GetCommentDetails());
        videos.Add(video1);

        Video video2 = new Video ("Video 2", "Author 2", 200);
        Comment comment3 = new Comment ("User 3", "Comment 3");
        video2.AddComment(comment3.GetCommentDetails());
        Comment comment4 = new Comment ("User 4", "Comment 4");
        video2.AddComment(comment4.GetCommentDetails());
        Comment comment5 = new Comment ("User 5", "Comment 5");    
        video2.AddComment(comment5.GetCommentDetails());
        videos.Add(video2);

        Video video3 = new Video ("Video 3", "Author 3", 275);        
        Comment comment6 = new Comment ("User 6", "Comment 6");
        video3.AddComment(comment6.GetCommentDetails());
        Comment comment7 = new Comment ("User 7", "Comment 7");
        video3.AddComment(comment7.GetCommentDetails());
        Comment comment8 = new Comment ("User 8", "Comment 8");
        video3.AddComment(comment8.GetCommentDetails());
        Comment comment9 = new Comment ("User 9", "Comment 9");
        video3.AddComment(comment9.GetCommentDetails());
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nVideo Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration: {video.GetLength()} sec");
            Console.WriteLine($"\n{video.NumberOfComments()} comments:");
            foreach(string[] commentDetails in video.comments)
            {
                Console.WriteLine($"\n    -{commentDetails[0]}");
                Console.WriteLine($"        {commentDetails[1]}");
            }
        }
    }
}