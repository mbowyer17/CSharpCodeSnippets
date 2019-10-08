using System;

namespace SimpleClasses
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// create a new instance of the car class - declaring a new car in memory
			Car myCar = new Car();

			myCar.Make = "Oldsmoblie";
			myCar.Model = "Cutlas Supreme";
			myCar.Year = 1986;
			myCar.Colour = "Silver";

			Console.WriteLine ("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Colour);

			// Returns back a value
			//decimal value = DetermineMarketValue (myCar);

			//Console.WriteLine ("{0:C}", value);

			Console.WriteLine ("{0:C}", myCar.DetermineMarketValue());

			Console.ReadLine ();
		}

		// Car is refer to the name of the class
		private	static decimal DetermineMarketValue(Car car)
		{
			decimal carValue = 100.0M;

			// Someday i might look up a car
			// online wevservice to get
			// accurate value
			return carValue;
		}
	}

	// defined a class with 4 propertise with 4 data types
	// Classes are containers for methods 
	class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Colour { get; set;	}

		public decimal DetermineMarketValue()
		{
			decimal carValue;
			if (Year > 1990)
				carValue = 11000;
			else
				carValue = 2000;

			return carValue;
		}	
		}	
}
