using System;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoops = 100;
            StarStuff s = new StarStuff();
            s.BruteStars();
            s.LoopStars(numberOfLoops);
            s.InvertStars(numberOfLoops);
            s.AlternateStars(numberOfLoops);
        }
    }
}
