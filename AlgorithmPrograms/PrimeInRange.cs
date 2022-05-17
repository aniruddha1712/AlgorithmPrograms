using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class PrimeInRange
    {
        public static void FindPrime(int a,int b)
        {
            for (int i = a; i <= b; i++)
            {

                // Skip 0 and 1 as they are
                // neither prime nor composite
                if (i == 1 || i == 0)
                    continue;
                
                int flag = 1;
                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.Write(i +" ");
            }
        }
    }
}
