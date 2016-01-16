using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _283_MoveZeroes
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 1,0 };
			MoveZeros(nums);
			foreach (var num in nums)
			{
				Console.WriteLine(num);
			}
			Console.ReadLine();
		}

		public static void MoveZeros(int[] nums)
		{
			int zero = 0;

			int j;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == 0)
				{
					zero++;
					j = i;
					while (i > 0 && nums[i - 1] != 0)
					{
						nums[i] = nums[i - 1];
						nums[i - 1] = 0;
						i--;
					}
					i = j;
				}
			}
			
			for (int i = zero; i < nums.Length; i++)
			{
				nums[i - zero] = nums[i];
			}
			for (int i = 0; i < zero; i++)
			{
				nums[nums.Length - i - 1] = 0;
			}
		}
	}
}
