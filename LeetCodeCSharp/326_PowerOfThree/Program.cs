using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _326_PowerOfThree
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(IsPowerOfThree(19682));
		}

		public static bool IsPowerOfThree(int n)
		{
			if (n == 0)
			{
				return false;
			}
			double dR = Math.Log(n, 3);
			int iR = (int)Math.Round(dR);
			double result = Math.Abs(dR - iR);
			if (result < 0.0000000000001)
			{
				return true;
			}
			return false;
		}
	}
}
