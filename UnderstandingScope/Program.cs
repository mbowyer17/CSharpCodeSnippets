using System;


// Whenever you declare a variable in a block of code, that variable is only alivee is in that code block

namespace UnderstandingScope
{
	class MainClass
	{
		// Still avaiable to all the members of the class
		// Define at the class level so its available to everthing below
		// private means that a method can be called by any other method inside the same class
		// public are suppose to be used to be called outside the class
		private	static string k = "";

		public static void Main (string[] args)
		{
			string j = "";

			for (int i = 0; i < 10; i++) {
				j = i.ToString ();
				k = i.ToString ();
				Console.WriteLine (i);

				if (i == 9) {
					string l = i.ToString ();
					//Console.WriteLine (l);
				}
				//Console.WriteLine (l);
			}
			//Console.WriteLine (i);

			Console.WriteLine ("Outside of the for loop: " + j);
			Console.WriteLine ("Outside of the for loop: " + k);

			HelperMethod ();

			Car myCar = new Car ();

			myCar.DoSomething ();

			Console.ReadLine ();
		}

		//Helper method
		static void HelperMethod()
		{
			Console.WriteLine ("Value of k from HelperMethod(): " + k);
		}



		class Car
		{
			public void DoSomething()
			{
				Console.WriteLine (helperMethod);
			}

			private void helperMethod()
			{
				return "Hello World!";
			}

		}
	}
}
