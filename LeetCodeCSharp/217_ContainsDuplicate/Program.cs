using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217_ContainsDuplicate
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public bool ContainsDuplicate(int[] nums)
		{
			HashSet<int> hs = new HashSet<int>();
			foreach (var num in nums)
			{
				if (hs.Add(num) == false)
				{
					return true;
				}
			}
			return false;
		}
	}
}
