using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _258_AddDigits
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public int AddDigits(int num)
		{
			return (num - 1) % 9 + 1;
		}
	}
}

/*

	1	1
	2	2
	3	3
	4	4
	5	5
	6	6
	7	7
	8	8
	9	9

	10	1
	11	2
	12	3
	13	4
	14	5
	15	6
	16	7
	17	8
	18	9

	19	1
	20	2
	21	3
	22	4
	23	5
	24	6
	25	7
	26	8
	27	9

	28	1

*/
