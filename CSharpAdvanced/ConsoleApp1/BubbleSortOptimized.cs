using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BubbleSortOptimized<T> where T : IComparable<T>
    {
        public static void BubbleSortOptimizedMethod(T[] arr)
        {
            int n = arr.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i += 1)
            {
                swapped = false;
                for (int j = 0; j < n - 1 - i; j += 1)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
