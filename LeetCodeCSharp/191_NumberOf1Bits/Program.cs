using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191_NumberOf1Bits
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(HammingWeight(7));
			Console.ReadLine();
		}

		public static int HammingWeight(uint n)
		{
			if (n == 0)
			{
				return 0;
			}

			for (int i = 1; i < 32; i++)
			{
				if ((n &= n - 1) == 0)
				{
					return i;
				}
			}

			return 32;
		}
		
	}
}

// 7	111
// 6	110
// 5	101
// 4	100
// 3	011
// 2	010
// 1	001
