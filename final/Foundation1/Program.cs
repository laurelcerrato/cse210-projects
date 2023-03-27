using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        Comment comment1 = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();

        Comment comment4 = new Comment();
        Comment comment5 = new Comment();
        Comment comment6 = new Comment();

        Comment comment7 = new Comment();
        Comment comment8 = new Comment();
        Comment comment9 = new Comment();

    //Add video info
        video1._author = "Nelson Packerson";
        video1._lenght = 3;
        video1._title = "How to make a cake";

        video2._author = "Andrea";
        video2._lenght = 10;
        video2._title = "Cleaning my home";

        video3._author = "Stuart C.";
        video3._lenght = 20;
        video3._title = "How to groom your Dog.";
    //Create comments
        comment1._name = "Stuart";
        comment1._commentext = "Thank you!";

        comment2._name = "Andres";
        comment2._commentext = "Great recipe!";

        comment3._name = "Daniel";
        comment3._commentext = "Good tutorial";

        comment4._name = "Ruben";
        comment4._commentext = "What soap are you using?";

        comment5._name = "Jose";
        comment5._commentext = "That must smell very good!";

        comment6._name = "Mario";
        comment6._commentext = "You give really good vibes!";

        comment7._name = "Brayan";
        comment7._commentext = "My schnauzer won't let me groom her!";

        comment8._name = "Eduardo";
        comment8._commentext = "Would you do another of this videos?";

        comment9._name = "Daniela";
        comment9._commentext = "Thank you so much, I really needed this!";
    // Add comments to list of comments
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);

        //List Of videos
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach(Video video in videos){
            video.DisplayVideoInfo();
        }
    }
}