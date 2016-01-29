using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136_SingleNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 0, 0, 1, 1, 2 };
			Console.WriteLine(SingleNumber(nums));
			Console.ReadLine();
		}

		public static int SingleNumber(int[] nums)
		{
			int singleNum = 0;

			if (nums.Length == 1)
			{
				return nums[0];
			}

			Array.Sort(nums);
			for (int i = 0; i < nums.Length; i += 2)
			{
				if (i == nums.Length - 1)
				{
					return nums[i];
				}
				if (nums[i] != nums[i + 1])
				{
					singleNum = nums[i];
					break;
				}
			}

			return singleNum;
		}
	}
}
