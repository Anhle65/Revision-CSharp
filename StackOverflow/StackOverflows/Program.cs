namespace StackOverflow
{
    using global::StackOverflow.StackOverflow;
    using System;

    namespace StackOverflow
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var post = new StackOverflowPost();
            post.TotalVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("Hello World!");
            post.TotalVote();
        }
    }
}
