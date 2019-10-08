using System;

namespace iterationstatment
{
	// For iteration statement
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Begin declaring i (variable) to 0 (i = 0)
			// Aslong as i is less than 10, continue to execute the code below(i < 10)
			// each time we iterate we increase the increment by 1 (i++)
			for (int i = 0; i < 10; i++) {
				//Console.WriteLine (i);

				if (i == 7) {
					Console.WriteLine ("Found Seven");
					// Break out of the iteration (Stop the counting)
					break;
				}
			}
			// Use tab twice for snippets
			for (int myValue = 0; myValue < 12; myValue++) {
				Console.WriteLine (myValue);
			}
			Console.ReadLine ();
		}
	}
}
