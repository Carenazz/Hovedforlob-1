using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 7, 1, 5, 10, 9, 8, 2, 6};
            Sort(arr, 0, 9);
            PrintArray(arr, 10);
            Console.ReadLine();
        }

        static void Sort(int[] arr, int low, int high)
        {
            Sort sort = new Sort();
            if (low < high)
            {
                int pi = sort.QuickSorter(arr, low, high);

                Sort(arr, low, pi - 1);
                Sort(arr, pi + 1, high);
            }
        }

        static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }
        }
    }
}
