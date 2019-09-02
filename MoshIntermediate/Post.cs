using System;

namespace MoshIntermediate
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _createdDate;
        private int _votes;
        public void MakePost(string title, string description)
        {
            _title = title;
            _description = description;
            _createdDate = DateTime.Now;
        }

        public void UpVote()
        {
            _votes++;
        }
        public void DownVote()
        {
            if (_votes >= 1)
            {
                _votes--;
            }
        }

        public void GetPost()
        {
            Console.WriteLine(_title + "\n" + _description + "\nCreated on: " + _createdDate + "\nVotes: " + _votes);
        }
    }
}