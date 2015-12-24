using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleＯverloadedHelperMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			string myValue = SuperSecretFormula();
			string myValue1 = SuperSecretFormula("UCW");
			Console.WriteLine(myValue);
			Console.WriteLine(myValue1);
			Console.ReadLine();
		}

		private static string SuperSecretFormula()
		{
			// some cool stuff here
			return "Hello World!";
		}

		private static string SuperSecretFormula(string name)
		{
			return String.Format("Hello, {0}!", name);
		}
	}
}
