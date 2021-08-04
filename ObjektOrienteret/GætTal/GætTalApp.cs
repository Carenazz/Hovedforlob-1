using System;

namespace GætEtTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Tal tal = new Tal();
            Spilleren navn = new Spilleren();

            string name;
            Console.Write("What's your name? ");
            navn.Name(name = Console.ReadLine());
            Console.WriteLine("Hello " + navn.Name(name));

            do
            {
                int guess, howHigh;
                Console.Write("How high should the number go: ");
                int.TryParse(Console.ReadLine(), out howHigh);
                tal.MyRandomNumber(howHigh);
            
                do
                {
                    Console.Write("Guess a number between 0 and " + howHigh + ": ");
                    int.TryParse(Console.ReadLine(), out guess);
                    Console.WriteLine("You guessed: " + guess);
                    if (guess == tal.result)
                    {
                        Console.WriteLine("You guessed the number!");
                        tal.Guessed(guess);
                    }
                    else if (guess < tal.result)
                    {
                        Console.WriteLine("I am thinking of a higher number");
                    }
                    else
                    {
                        Console.WriteLine("I am thinking of a lower number");
                    }

                } while (!tal.Guessed(guess));

            } while (Continue());
            Console.WriteLine("Thanks for using Mike's guess number application");
        }

        static bool Continue()
        {
            string check;
            Console.WriteLine("Want to continue using the application? Y / N");
            check = Console.ReadLine();
            if (check.ToLower() == "y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
