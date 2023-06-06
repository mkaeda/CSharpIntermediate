using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get { return _createdAt; } }
        public int Votes { get { return _votes; } }

        private readonly DateTime _createdAt;
        private int _votes;

        public Post()
        {
            _createdAt = DateTime.Now;
            _votes = 0;
        }

        public void UpVote()
        {
            _votes++;
        }

        public void DownVote()
        {
            _votes--;
        }
    }
}
