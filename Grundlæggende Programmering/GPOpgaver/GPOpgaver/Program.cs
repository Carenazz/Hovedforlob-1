using System;
using System.Runtime.InteropServices;

namespace GPOpgaver
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] intArray = { 1, 3, 4, 5, 6, 8, 9, 11 };
            Opgaver.StepsInLinearSearch(9, intArray);
            Opgaver.StepsInLinearSearch(11, intArray);
            Opgaver.StepsInLinearSearch(5, intArray);
            Console.ReadLine();
        }
    }
}
