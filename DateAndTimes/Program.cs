using System;

namespace DatesAndTimes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// displays the date and time currently
			DateTime myValue = DateTime.Now;
			//Console.WriteLine (myValue.ToString ());

			// Aditional helper methods
			//Console.WriteLine(myValue.ToShortTimeString());
			//Console.WriteLine(myValue.ToShortDateString());
			//Console.WriteLine(myValue.ToLongTimeString());
			//Console.WriteLine(myValue.ToLongDateString());

			// Day time math, chaining method callings together
			//Console.WriteLine(myValue.AddDays(3).ToLongDateString());
			//Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
			//Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

			//Console.WriteLine(myValue.Month);

			//DateTime myBirthday = new DateTime (1969, 12, 7);
			//Console.WriteLine(myBirthday.ToShortDateString());

			// shows how many days i have lived for 
			DateTime myBirthday = DateTime.Parse ("26/04/1999");
			TimeSpan myAge = DateTime.Now.Subtract (myBirthday);
			Console.WriteLine (myAge.TotalDays);

			Console.ReadLine ();

		}
	}
}
