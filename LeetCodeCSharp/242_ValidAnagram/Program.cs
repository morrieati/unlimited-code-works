using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242_ValidAnagram
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "a";
			string t = "b";
			Console.WriteLine(IsAnagram(s,t));
			Console.ReadLine();
		}

		public static bool IsAnagram(string s, string t)
		{
			if (s.Length == t.Length)
			{
				char[] ss = s.ToCharArray();
				char[] ts = t.ToCharArray();

				Array.Sort(ss);
				Array.Sort(ts);

				string sss = new string(ss);
				string tss = new string(ts);

				return sss == tss;
			}

			return false;
		}
	}
}
