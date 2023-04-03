using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make a cake","Nelson", 3);
        Video video2 = new Video("Cleaning my home","Andrea", 10);
        Video video3 = new Video("How to groom your Dog", "Stuart C",20);

        Comment comment1 = new Comment("Stuart","Thank you!");
        Comment comment2 = new Comment("Andres","Great recipe!");
        Comment comment3 = new Comment("Daniel","Good tutorial");

        Comment comment4 = new Comment("Ruben","What soap are you using?");
        Comment comment5 = new Comment("Jose","That must smell very good!");
        Comment comment6 = new Comment("Mario","You give really good vibes!");

        Comment comment7 = new Comment("Brayan","My schnauzer won't let me groom her!");
        Comment comment8 = new Comment("Eduardo","Would you do another of this videos?");
        Comment comment9 = new Comment("Daniela","Thank you so much, I really needed this!");
    //Create comments
        // comment1._name = "Stuart";
        // comment1._commentext = "Thank you!";

        // comment2._name = "Andres";
        // comment2._commentext = "Great recipe!";

        // comment3._name = "Daniel";
        // comment3._commentext = "Good tutorial";

        // comment4._name = "Ruben";
        // comment4._commentext = "What soap are you using?";

        // comment5._name = "Jose";
        // comment5._commentext = "That must smell very good!";

        // comment6._name = "Mario";
        // comment6._commentext = "You give really good vibes!";

        // comment7._name = "Brayan";
        // comment7._commentext = "My schnauzer won't let me groom her!";

        // comment8._name = "Eduardo";
        // comment8._commentext = "Would you do another of this videos?";

        // comment9._name = "Daniela";
        // comment9._commentext = "Thank you so much, I really needed this!";
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