using System;

namespace YouTubeVideos
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _lengthInSeconds;
        public List<Comment> _comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            _title = title;
            _author = author;
            _lengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }
        public int GetNumberOfComments()
        {
            return _comments.Count;
        }
    }
}