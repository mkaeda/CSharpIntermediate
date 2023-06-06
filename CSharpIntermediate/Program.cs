using System;
using System.Threading;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise #1
            var swatch = new StopWatch();
            swatch.Start();
            Thread.Sleep(5000);
            var duration = swatch.Stop();
            Console.WriteLine(duration);

            // Exercise #2
            var post = new Post()
            {
                Title = "I need help!!",
                Description = "Question about some random and obscure problem..."
            };
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.CreatedAt);
            Console.WriteLine(post.Votes);
            post.UpVote();
            post.UpVote();
            Console.WriteLine(post.Votes);
            post.DownVote();
            post.DownVote();
            post.DownVote();
            Console.WriteLine(post.Votes);

            // Classes, Interfaces, and OOP
            // Exercise #1: Design a Stack
            var stack = new Stack<string>();
            try
            {
                Console.WriteLine("Stack Count: " + stack.Count);
                stack.Pop();
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Something went wrong!");
            }       
            stack.Push("goodbye, world");
            stack.Push("hello, world");
            Console.WriteLine("Stack Count: " + stack.Count);
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("Stack Count: " + stack.Count);
        }
    }
}
