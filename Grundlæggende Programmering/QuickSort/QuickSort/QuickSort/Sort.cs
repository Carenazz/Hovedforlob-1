using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Sort
    {
        public int QuickSorter(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = (low - 1);

            for (int j = low; j <= high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr[i], arr[j]);
                }
            }
            Swap(arr[i + 1], arr[high]);
            return (i + 1);
        }

        void Swap(int a, int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
