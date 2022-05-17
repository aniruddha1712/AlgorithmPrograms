using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class FindYourNumber
    {
        static int start = 1;
        static int end = 100;

        static int GetMid()
        {
            int mid = (start + end) / 2;
            return mid;
        }
        static void Usernumber(int midNum)
        {
            Console.WriteLine("1.Number is greater than {0} : ", midNum);
            Console.WriteLine("2.Number is less than equal to {0} : ", midNum);
            Console.Write("Enter your option : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    start = midNum + 1;
                    break;
                case 2:
                    end = midNum;
                    break;
                default:
                    Console.WriteLine("Enter Valid Option!");
                    break;
            }
        }
        public static void YourNumber()
        {
            while (start != end)
            {
                int mid = GetMid();
                Usernumber(mid);
            }
            if (start == end)
            {
                Console.WriteLine("Your number is {0}", start);
            }
        }
    }
}

