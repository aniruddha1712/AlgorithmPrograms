using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public static void InsertSort(string[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                string key = arr[i];
                int j = i - 1;

                while (j >= 0 && key.CompareTo(arr[j])<0)
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = key;
            }
        }
        public static void PrintArray(string[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
