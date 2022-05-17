using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option\n1:String Permutation\n2:Binary search for word\n3:Insertion sort\n4:Bubble sort\n5:Merge Sort" +
                "\n6:Angram Detector\n7:Find prime in given Range\n8:Find pelindrome/Anagram\n9:Find your number\n10:Custom message");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    string str = "MAN";
                    Permutation.Permute(str, 0, str.Length - 1);
                    break;
                case 2:
                    string[] arr = { "joey", "ram", "ross", "shyam", "tony" }; //work for sorted array
                    string search = "joey";
                    int result = BinarySearchForWord.BinarySearch(arr, search);
                    if (result == -1)
                        Console.WriteLine("Element not present");
                    else
                        Console.WriteLine("Element found at index " + result);
                    break;
                case 3:
                    string[] arr1 = { "tony", "ram", "shyam", "ross", "joey" };
                    InsertionSort.PrintArray(arr1);
                    InsertionSort.InsertSort(arr1);
                    InsertionSort.PrintArray(arr1);
                    break;
                case 4:
                    int[] arr2 = { 21, 45, 67, 89, 34, 32, 12 };
                    BubbleSort.PrintArray(arr2);
                    BubbleSort.SortBubble(arr2);
                    BubbleSort.PrintArray(arr2);
                    break;
                case 5:
                    int[] arr3 = { 12, 11, 13, 5, 6, 7 };
                    MergeSort.PrintArray(arr3);
                    MergeSort.Sort(arr3, 0, arr3.Length - 1);
                    MergeSort.PrintArray(arr3);
                    break;
                case 6:
                    string str1 = "heart";
                    string str2 = "earth";
                    AnagramDetection.CheckAnagram(str1,str2);
                    break;
                case 7:
                    PrimeInRange.FindPrime(0, 1000);
                    break;
                case 8:
                    PrimePelindrome.Input();
                    break;
                case 9:
                    Console.WriteLine("Think of a number between 0 to 100");
                    FindYourNumber.YourNumber();
                    break;
                case 10:
                    CustomMessage.Pattern();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
