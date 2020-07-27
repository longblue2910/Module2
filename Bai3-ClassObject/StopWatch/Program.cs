using System;
namespace BT_stop_watch
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Star();
            for (int i = 1; i < 100000; i++)
            {
                Console.WriteLine("I luv you");
            }
            stopWatch.Stop();
            Console.WriteLine(stopWatch.GetTimeDoing());
        }
    }
}