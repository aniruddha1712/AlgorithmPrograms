using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class BinarySearchForWord
    {
        public static int BinarySearch(string[] arr, string search)
        { 
                int start = 0, last = arr.Length - 1;
                while (start <= last)
                {
                    int m = start + (last - start) / 2;

                    int res = search.CompareTo(arr[m]);

                    // Check if x is present at mid
                    if (res == 0)
                        return m;

                    // If x greater, ignore left half
                    if (res > 0)
                        start = m + 1;

                    // If x is smaller, ignore right half
                    else
                        last = m - 1;
                }
                return -1;
        }
    }
}
