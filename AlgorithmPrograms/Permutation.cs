using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
	class Permutation
	{
        
		public static void Permute(string str,int start, int last) // (start=0),(last=string length -1)
		{
			if (start == last)
				Console.Write(str+" ");
			else
			{
				for (int i = start; i <= last; i++)
				{
					str = Swap(str, start, i);
					Permute(str, start + 1, last);
					str = Swap(str, start, i);
				}
			}
		}
		public static string Swap(string a,int i, int j)
		{
			char temp;
			char[] charArray = a.ToCharArray();
			temp = charArray[i];
			charArray[i] = charArray[j];
			charArray[j] = temp;
			string s = new string(charArray);
			return s;
		}
	}
}



