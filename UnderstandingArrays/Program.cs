using System;

namespace UnderstandingArrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Bad example when it comes to dealing with multiple numbers
			int number1 = 4;
			int number2 = 8;
			int number3 = 15;
			int number4 = 16;
			int number5 = 23;

			if (number1 == 16) {
				
			} else if (number2 == 16) {
				
			} else if (number3 == 16) {
				
			}
			*/
//---------------------------------------------------------------------------------------------------------
			/*
			// creating a int array with 5 elements (int[5])
			int[] numbers = new int[5];

			// putting values in each element of the array (numbers [0])
			numbers [0] = 4;
			numbers [1] = 8;
			numbers [2] = 15;
			numbers [3] = 16;
			numbers [4] = 23;
			//numbers [5] = 43;

			// Displays in console the number stored in the 2nd element of the array 
			Console.WriteLine (numbers [1]);
			// Displays how many elements are in the array
			Console.WriteLine(numbers.Length);
			Console.ReadLine ();
			*/
//---------------------------------------------------------------------------------------------------------------
			// Shortcut for writing out arrays
			//int[] numbers = new int[] { 4, 8, 15, 16, 23, 42}

			//string[] names = new string[] { "Matthew", "Tayla", "John", "Jeff Lee" };

			/*
			// Iterating through each element until we reach the lenght of the array
			for (int i = 0; i < names.Length; i++) {
				Console.WriteLine (names [i]);
			}
			Console.ReadLine ();
			*/
//-----------------------------------------------------------------------------------------------------------------
			// Second style of iteration 
			//string[] names = new string[] { "Matthew", "Tayla", "John", "Jeff Lee" };
			// loop through every single name in our array of names and for each item, it will copy the current element into this temporary variable called name
			/* foreach (string name in names) {
				Console.WriteLine (name);
				
			}
			//Console.ReadLine ();
*/
//------------------------------------------------------------------------------------------------------------------

			// tAKE A STRING AND REVERSE THE string in a array

			string zig = "Hello my baby " + ", Hello my honey";

			char[] charArray = zig.ToCharArray ();
			Array.Reverse (charArray);

			// Reverses the order
			foreach (char zigChar in charArray) {
				Console.Write (zigChar);
			}
			Console.ReadLine ();
		}
	}
}
