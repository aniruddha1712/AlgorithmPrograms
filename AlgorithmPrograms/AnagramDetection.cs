using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class AnagramDetection
    {
        public static void CheckAnagram(string str1,string str2)
        {
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings {0} and {1} are Anagram",str1,str2);
            }
            else
            {
                Console.WriteLine("Both the strings {0} and {1} are not Anagram", str1, str2);
            }
        }
    }
}
