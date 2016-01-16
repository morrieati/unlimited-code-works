using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _292_NimGame
{
	class Program
	{
		static void Main(string[] args)
		{
			
		}

		public bool CanWinNim(int n)
		{
			return !(n % 4 == 0);
		}
	}
}

/*

	1	1
	2	2
	3	3
	4	false
	5	1
	6	2
	7	3
	8	false

*/
