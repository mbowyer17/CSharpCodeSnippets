using System;

namespace ObjectLifetime
{
	class MainClass
	{
		// static classes will available to you without requiring you create an instance of a class
		// Constructors are method that allow us to write code at the moment when the class is being created
		public static void Main (string[] args)
		{
			// mycar only exist within the main method, it can not be reference outside main method
			Car myCar = new Car ();

			Car.MyMethod ();
			/*
			myCar.Make = "Oldmobile";
			myCar.Model = "Cutlas Supreme";
			myCar.Year = 1986;
			myCar.Colour = "Silver";
			 

			// create a "handle" but not attached to any "buckets" of cars in our memory
			Car myOtherCar;

			// copies the address of myCar so uses the same attributes 
			myOtherCar = myCar;

			//Car myThirdCar = new Car ("Bugatti", "Super Sport", 2015, "Red");
							
			Console.WriteLine ("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Colour);

			//Changing attributes from myOther car
			myOtherCar.Model = "98";

			Console.WriteLine ("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Colour);

			// remove one of the handle to the bucket. Which causes a handle exception 
			myOtherCar = null;

			//Console.WriteLine ("{0} {1} {2} {3}", myOtherCar.Colour, myOtherCar.Make, myOtherCar.Model, myOtherCar.Year);

			//References are gone completly 
			myCar = null;

			Console.WriteLine ("{0} {1} {2} {3}", myThirdCar.Make, myThirdCar.Model, myThirdCar.Year, myThirdCar.Colour);
*/
			Console.ReadLine ();
		}
	}

	class Car
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string Colour { get; set; }

		/*
		// Contructor 
		public Car()
		{
			// you could load from a configuration file
			// a database, etc
			Make = "Nissan";
			// this. keyword is optional, refers to this instance of this object
		}

		// Overloaded constructor

		public Car(string make, string model, int year, string colour)
		{
			// "Make" is refering to the property, and "make" is refering to input perameter
			Make = make;
			 Model = model;
			Year = year;
			Colour = colour;


		}
		*/

		public static void MyMethod()
		{
			Console.WriteLine ("Called the static MyMethod");
		}
	}
}
