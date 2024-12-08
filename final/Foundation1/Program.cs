using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Sta ima buraz","Ljubi Chika", 47);
        Comment c1 = new Comment("Josh", "great video");
        Comment c2 = new Comment("Mary", "I liked the point of the video");
        Comment c3 = new Comment("Alex", "good work");
        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        v1.Display();
        
        Video v2 = new Video("How to cook pasta","Chef", 420);
        Comment c4 = new Comment("Lily", "Very helpful");
        Comment c5 = new Comment("Phil", "You cooked the pasta perfectly");
        Comment c6 = new Comment("George", "My kids didn't like your way of making pasta");
        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);
        v2.Display();
        
                

    }
}