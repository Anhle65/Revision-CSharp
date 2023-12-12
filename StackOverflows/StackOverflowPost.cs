﻿namespace StackOverflow
{
    using System;

    namespace StackOverflow
    {
        public class StackOverflowPost
        {
            private int _upvote = 0;
            private int _downvote = 0;
            public StackOverflowPost()
            {
                Console.WriteLine("A new post is created");
            }
            public void UpVote()
            {
                _upvote++;
            }
            public void DownVote()
            {
                _downvote++;
            }
            public void TotalVote()
            {
                Console.WriteLine($"Total upvote: " + _upvote);
                Console.WriteLine($"Total downvote: " + _downvote);
            }
        }
    }
}
