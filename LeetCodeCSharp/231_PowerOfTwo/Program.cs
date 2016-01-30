using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231_PowerOfTwo
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public bool IsPowerOfTwo(int n)
		{
			if (n == 0)
			{
				return false;
			}
			if (n == -2147483648)
			{
				return false;
			}

			if ((n & (n - 1)) == 0)
			{
				return true;
			}
			return false;
		}
	}
}
