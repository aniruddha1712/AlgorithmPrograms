using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class PrimePelindrome
    {
        public static void Input()
        {
            Console.WriteLine("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int num2 = int.Parse(Console.ReadLine());
            CheckPrime(num1);
            CheckPrime(num2);
            bool anagram =FindAnagram(Convert.ToString(num1), Convert.ToString(num2));
            bool palindrome1 = FindPalindrome(num1);
            bool palindrome2 = FindPalindrome(num2);
            if (anagram)
            {
                Console.WriteLine("Both values are Anagram");

            }
            else
            {
                Console.WriteLine("Both the values are not Anagram");
            }
            if (palindrome1)
            {
                Console.WriteLine("{0} is Palindrome",num1 );
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome",num1);
            }
            if (palindrome2)
            {
                Console.WriteLine("{0} is Palindrome", num2);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome", num2);
            }
        }
        public static void CheckPrime(int number)
        {
            int a = 1;
            if (number == 1 || number == 0)
            {
                a = 0;
            }

            for (int i = 2; i <= number / 2; ++i)
            {
                if (number % i == 0)
                {
                    a = 0;
                    break;
                }
            }
            if(a==1)
                Console.WriteLine("{0} is prime",number);
            else
                Console.WriteLine("{0} is not prime",number);
        }
        public static bool FindPalindrome(int number)
        {
            int rem, rev = 0, temp;
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            }
            if (temp == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool FindAnagram(string string1, string string2)
        {

            char[] ch1 = string1.ToLower().ToCharArray();
            char[] ch2 = string2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string newString1 = new string(ch1);
            string newString2 = new string(ch2);
            if (newString1 == newString2)
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
