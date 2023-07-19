using PostAndComments.Entities;
using System;

namespace PostsAndComments // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment 
            { 
                Text = "Have a nice trip"
            };

            Comment c2 = new Comment
            {
                Text = "Wow, that's awesome!"
            };

            Post p1 = new Post
            {
                Moment = DateTime.Now,
                Title = "Travelling to New Zealand",
                Content = "I'm going to visit this wonderful country",
                Likes = 12
            };

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment
            {
                Text = "Good night"
            };

            Comment c4 = new Comment
            {
                Text = "May the Force be with you"
            };

            Post p2 = new Post
            {
                Moment = DateTime.Now,
                Title = "Good night guys",
                Content = "See you tomorrow",
                Likes = 5
            };

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}