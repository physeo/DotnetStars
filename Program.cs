using System;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1: *");
            //Console.WriteLine("2: **");
            //Console.WriteLine("3: ***");
            //Console.WriteLine("4: ****");
            //Console.WriteLine("5: *****");
            //Console.WriteLine("6: ******");
            //Console.WriteLine("7: *******");
            //Console.WriteLine("8: ********");
            //Console.WriteLine("9: *********");
            //Console.WriteLine("10: **********");

            string myStars = "";
            int numberOfLoops = 10000;
            bool invert = false;
            for (int i = 0; i < numberOfLoops; i++)
            {
                if (i > 0 && i % 10 == 0)
                    invert = !invert;


                if (!invert)
                    myStars += "*";
                else
                    myStars = myStars.RemoveEndCharacter();

                string line = i + ": " + myStars;
                Console.WriteLine(line);
            }
        }
    }
}
