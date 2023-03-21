using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1a = new Comment();
        comment1a._name = "Peter";
        comment1a._text = "Best video ever!";

        Comment comment1b = new Comment();
        comment1b._name = "James";
        comment1b._text = "Meh, just ok.";

        Comment comment1c = new Comment();
        comment1c._name = "John";
        comment1c._text = "Not my favorite.";


        Video video1 = new Video();
        video1._title = "Video One";
        video1._author = "Author One";
        video1._seconds = 30;
        video1._comments.Add(comment1a);
        video1._comments.Add(comment1b);
        video1._comments.Add(comment1c);

        video1.DisplayVideo();


        Comment comment2a = new Comment();
        comment2a._name = "Rizzo";
        comment2a._text = "I loved it!";

        Comment comment2b = new Comment();
        comment2b._name = "Remi";
        comment2b._text = "This video brightened my day.";

        Comment comment2c = new Comment();
        comment2c._name = "Mavi";
        comment2c._text = "I'm so glad I found this video today!";


        Video video2 = new Video();
        video2._title = "Video Two";
        video2._author = "Author Two";
        video2._seconds = 90;
        video2._comments.Add(comment2a);
        video2._comments.Add(comment2b);
        video2._comments.Add(comment2c);

        video2.DisplayVideo();


        Comment comment3a = new Comment();
        comment3a._name = "Frasier";
        comment3a._text = "Magnificent!";

        Comment comment3b = new Comment();
        comment3b._name = "Niles";
        comment3b._text = "A bit too flashy for my taste.";

        Comment comment3c = new Comment();
        comment3c._name = "Marty";
        comment3c._text = "It's the Bees Knees!";

        Comment comment3d = new Comment();
        comment3d._name = "Daphne";
        comment3d._text = "Reminds me of my brother, Simon.";

        Video video3 = new Video();
        video3._title = "Video Three";
        video3._author = "Author Three";
        video3._seconds = 112;
        video3._comments.Add(comment3a);
        video3._comments.Add(comment3b);
        video3._comments.Add(comment3c);
        video3._comments.Add(comment3d);

        video3.DisplayVideo();
    }
}