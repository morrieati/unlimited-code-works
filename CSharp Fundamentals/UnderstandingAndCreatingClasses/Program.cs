using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAndCreatingClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			Car myNewCar = new Car();
			myNewCar.Make = "Oldsmobile";
			myNewCar.Model = "Cutlas Supreme";
			myNewCar.Year = 1986;
			myNewCar.Color = "Silver";

			Console.WriteLine("{0} - {1} - {2}",
				myNewCar.Make,
				myNewCar.Model,
				myNewCar.Color);

			//double marketValueOfCar = DetermineMarketValue(myNewCar);
			Console.WriteLine("Car's value: {0:C}",
				myNewCar.DetermineMarketValue());

			Console.ReadLine();
		}

		private static double DetermineMarketValue(Car car)
		{
			double carValue = 100.0;
			
			// Somedat white come to go online and look up the car's value
			// and trieve its value into the carValue variable
			return carValue;
		}
	}

	class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Color { get; set; }

		public double DetermineMarketValue()
		{
			double carValue = 100.0;

			if (this.Year > 1990)
			{
				carValue = 10000.0;
			}
			else
			{
				carValue = 2000.0;
			}
			// Somedat white come to go online and look up the car's value
			// and trieve its value into the carValue variable
			return carValue;
		}
	}
}
