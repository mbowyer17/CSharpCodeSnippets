using System;
using System.Text;

namespace WorkingWithStrings
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// backslash ( \ ) is used to escape or insert escape sequuences into literal strings, allows use to input special characters
		//string myString = "My \"so-called\" life";
	
			// New line
		//string myString = "What if I need a\nnew line?";
		
		//string myString = "Go to your c:\\ drive";
		
		// tells c# that we want to use backslash characters, instead of escape sequences
		//string myString = @"Go to your c:\ drive";

		// can reused the input parametres multiple times
		//string myString = String.Format("{0} = {0}", "First", "Second");

		// Used to format currency
		//string myString = String.Format("{0:C}", 123.45);

		// Used for adding decimal and commons to long numbers
		//string myString = String.Format("{0:N}", 1234567890);
		
		// Used for percentages
		//string myString = String.Format("Percentage: {0:P}", .123);
		
		// Used for formating phone numbers, formating will go from right to left
		//string myString = String.Format("Phone Number: {0:(###)-###-####}", 12345697890);

		//string myString = " That summer we took threes across the board  ";
		
		// grabs everything from the 6th position onwards to 14th
		//myString = myString.Substring (6, 14);
		//myString = myString.ToUpper();
		
		// Replaces the spaces with + signs
		//myString = myString.Replace(" ", "+");
		// Remove values from the 6th position to the 14th
		//myString = myString.Remove(6, 14);
		
		// trims off addtional spaces in a string
		//myString = String.Format ("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim ().Length);

			/*
			string myString = "";
			for (int i = 0; i < 100; i++) {
				myString += "--" + i.ToString ();
			}
		*/ 
			// string builder uses less memory than above code
			StringBuilder myString = new StringBuilder();
			for (int i = 0; i < 100; i++) {
				// effective way to append additional information to the string or object
				myString.Append("--");
				myString.Append (i);
			}
		
		Console.WriteLine (myString);
		Console.ReadLine();

		}
	}
}
