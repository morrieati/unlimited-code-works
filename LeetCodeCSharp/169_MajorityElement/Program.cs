using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169_MajorityElement
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 3, 2, 3 };
			Console.WriteLine(MajorityElement(nums));
			Console.ReadLine();
		}
		
		public static int MajorityElement(int[] nums)
		{
			int elem = 0;
			int count = 1;
			int length = nums.Length;

			if (length == 1)
			{
				return nums[0];
			}
			
			var numList = nums.ToList();
			numList.Sort();
			for (int i = 0; i < length - 1; i++)
			{
				if (numList[i] == numList[i + 1])
				{
					count++;
					if (count > length / 2)
					{
						elem = numList[i];
						break;
					}
				}
				else
				{
					count = 1;
				}
			}

			return elem;
		}
	}
}
