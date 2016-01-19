using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171_ExcelSheetColumnNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(TitleToNumber("AB"));
			Console.ReadLine();
		}

		public static int TitleToNumber(string s)
		{
			int result = 0;
			char[] nums = s.ToCharArray();
			Array.Reverse(nums);

			for (int i = 0; i < nums.Length; i++)
			{
				result += (int)((nums[i] - 'A' + 1) * Math.Pow(26, i));
			}

			return result;
		}
	}
}
