using System;
using System.Threading;
using System.Diagnostics;

namespace ReactionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Press when ready");
                Console.ReadKey();

                Random r = new Random();
                int x = r.Next(2000, 7500);
                Thread.Sleep(x);

                Console.WriteLine("PRESS!");
                Stopwatch watch = new Stopwatch();
                watch.Start();
                Console.ReadKey();
                watch.Stop();

                Console.WriteLine("This is your reaction time " + watch.ElapsedMilliseconds);
                Console.WriteLine("Try again? Y / N: ");
            } while (Continue());
        }

        static bool Continue()
        {
            string check = Console.ReadLine();
            if (check.ToLower() == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
