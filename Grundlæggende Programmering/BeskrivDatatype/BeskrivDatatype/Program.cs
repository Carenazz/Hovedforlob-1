using System;

namespace BeskrivDatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplaySizeOf<char>();
            DisplaySizeOf<int>();
            DisplaySizeOf<float>();
            DisplaySizeOf<double>();
            DisplaySizeOf<decimal>();
            Console.WriteLine();
            ReturnBitOf<char>();
            ReturnBitOf<int>();
            ReturnBitOf<float>();
            ReturnBitOf<double>();
            ReturnBitOf<decimal>();
        }

        static unsafe void DisplaySizeOf<T>() where T : unmanaged
        {
            Console.WriteLine($"Size of {typeof(T)} is {sizeof(T)} in byte");
            for (int i = 0; i < sizeof(T) / 2; i++)
            {
                Console.WriteLine(new string('-', 20));
                Console.WriteLine("| 1 byte || 1 byte |");
                Console.WriteLine(new string('-', 20));
            }
            Console.ReadLine();
        }

        static unsafe void ReturnBitOf<T>() where T : unmanaged
        {
            Console.WriteLine($"Bits size of {typeof(T)} is {sizeof(T) * 8} in bits");
        }
    }
}
