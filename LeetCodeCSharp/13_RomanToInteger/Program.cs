using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RomanToInteger
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public int RomanToInt(string s)
		{
			int num = 0;
			int tempNum = 0;
			int lastNum = 0;

			Stack<int> numStack = new Stack<int>();
			char[] array = s.ToCharArray();

			numStack.Push(DigitTransform(array[0]));
			for (int i = 1; i < array.Length; i++)
			{
				tempNum = DigitTransform(array[i]);
				lastNum = numStack.Pop();

				if (lastNum < tempNum)
				{
					tempNum -= lastNum;
				}
				else
				{
					numStack.Push(lastNum);
				}
				numStack.Push(tempNum);
			}
			foreach (var digit in numStack)
			{
				num += digit;
			}

			return num;
		}

		public int DigitTransform(char digit)
		{
			int result = 0;
			switch (digit)
			{
				default:
					break;
				case 'I':
					result = 1;
					break;
				case 'V':
					result = 5;
					break;
				case 'X':
					result = 10;
					break;
				case 'L':
					result = 50;
					break;
				case 'C':
					result = 100;
					break;
				case 'D':
					result = 500;
					break;
				case 'M':
					result = 1000;
					break;
			}
			return result;
		}
	}
}

// I	1
// V	5
// X	10
// L	50
// C	100
// D	500
// M	1000