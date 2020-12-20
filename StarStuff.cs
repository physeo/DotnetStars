using System;
using System.Collections.Generic;
using System.Text;

namespace Stars
{
    public class StarStuff
    {
        public void BruteStars()
        {
            Console.WriteLine("1: *");
            Console.WriteLine("2: **");
            Console.WriteLine("3: ***");
            Console.WriteLine("4: ****");
            Console.WriteLine("5: *****");
            Console.WriteLine("6: ******");
            Console.WriteLine("7: *******");
            Console.WriteLine("8: ********");
            Console.WriteLine("9: *********");
            Console.WriteLine("10: **********");
        }

        public void LoopStars(int numberOfLoops)
        {
            string myStars = "";

            for (int i = 0; i < numberOfLoops; i++)
            {
                myStars = myStars + '*';
                string line = i + ": " + myStars;
                Console.WriteLine(line);
            }
        }

        public void InvertStars(int numberOfLoops)
        {
            string myStars = "";
            for (int i = 0; i < numberOfLoops; i++)
            {
                if (i <= numberOfLoops / 2)
                    myStars = myStars + '*';
                else
                    myStars = myStars.Substring(0, myStars.Length - 1);
                string line = i + ": " + myStars;
                Console.WriteLine(line);
            }
        }

        public void AlternateStars(int numberOfLoops)
        {
            string myStars = "";
            bool invert = false;
            for (int i = 0; i < numberOfLoops; i++)
            {
                if (i > 0 && i % 10 == 0)
                    invert = !invert;

                if (invert)
                    myStars = myStars.Substring(0, myStars.Length - 1);
                else
                    myStars = myStars + '*';

                string line = i + ": " + myStars;
                Console.WriteLine(line);
            }
        }
    }
}
