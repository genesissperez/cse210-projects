using System;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            //*VIDEO1
            Video video1 = new Video("¿Por qué cambiamos para ENCAJAR? | George de la Selva", "Farid Dieck", 1413);
            video1._comments.Add(new Comment("@josegarciabam4562", "I really like this movie..."));
            video1._comments.Add(new Comment("@maria_dev", "A great thought to start the week."));
            video1._comments.Add(new Comment("@carlos_p", "Farid always provides the best explanations."));

            //*VIDEO 2
            Video video2 = new Video("A Simple Way to Break a Bad Habit", "TED / Judson Brewer", 565);
            video2._comments.Add(new Comment("@dani-tk2uh", "Just got of The procrastination video..."));
            video2._comments.Add(new Comment("@katedolphin55", "My entire life is a bad habit at this point"));
            video2._comments.Add(new Comment("@sfeltbyyheart", "Thank you for this."));

            //*VIDEO3
            Video video3 = new Video("7 Rules To Success", "Brian Tracy", 365);
            video3._comments.Add(new Comment("@antonkroll6304", "This is a great start for 2026..."));
            video3._comments.Add(new Comment("@Gabielastella", "Thanks for sharing this, learned a lot."));
            video3._comments.Add(new Comment("@LTWA-ONE", "the small daily disciplines matters a lot."));

            //VIDEO 4
            Video video4 = new Video("Every single feature of C# in 10 minutes", "Train To Code", 590);
            video4._comments.Add(new Comment("@MsFm2000", "The best ten minutes of education I've had in a while."));
            video4._comments.Add(new Comment("@c@WayneGreen-g8l", "I've been programming in C# since 2006, and this video had a few things I had forgotten. Thanks.."));
            video4._comments.Add(new Comment("@MrThezyga", "I'm learning C# as another language after Python and this video was exactly what I was looking for, thanks"));

            // All the videos are stored here in a list
            List<Video> videoList = new List<Video>();
            videoList.Add(video1);
            videoList.Add(video2);
            videoList.Add(video3);
            videoList.Add(video4);


            foreach (Video video in videoList)
            {
                Console.WriteLine("===============================================================================");
                Console.WriteLine("Title: " + video._title);
                Console.WriteLine("Autor: " + video._author);
                Console.WriteLine("Duración: " + video._lengthInSeconds + " seconds");
                Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
                Console.WriteLine("\nVideo comments:");

                foreach (Comment comment in video._comments)
                {
                    Console.WriteLine(" - " + comment._name + ": " + comment._text);
                }

                Console.WriteLine();
            }
        }
    }
}