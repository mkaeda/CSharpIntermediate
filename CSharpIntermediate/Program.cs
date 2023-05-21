using System;
using System.Threading;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {

            var swatch = new StopWatch();
            swatch.Start();
            Thread.Sleep(5000);
            var duration = swatch.Stop();
            Console.WriteLine(duration);
        }
    }
}
