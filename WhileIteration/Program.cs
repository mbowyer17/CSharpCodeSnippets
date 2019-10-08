using System;

// While iteration keep iterating until a condition is met
namespace WhileIteration
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool displayMenu = true;
			// allows us to check when the condiftionm is true then we can break out of the while loop otherwise we will keep looping
			// continue to display the menu until the user decides to exit
			while (displayMenu == true)
			{
				displayMenu = MainMenu ();
			}
		
		}

		// print out a list of options for our users
		private static bool MainMenu()
		{
			Console.Clear ();

			Console.WriteLine ("Choose an option:");
			Console.WriteLine ("1) Print Number");
			Console.WriteLine ("2) Guessing Game");
			Console.WriteLine ("3) Exit");
			string result = Console.ReadLine ();

			if (result == "1") 
			{

				PrintNumbers ();
				return true;

			}
			else if (result == "2") 
			{

				GuessingGame ();
				return true;
			}
			else if (result == "3") 
			{
				return false;  
			}
			else
			{
				return true;	
			}

				
		}

		private static void PrintNumbers()
		{
			//Clears out the console 
			Console.Clear();

			Console.WriteLine ("Print numbers!");
			Console.Write ("Type a number: ");
			int result = int.Parse(Console.ReadLine());
			int counter = 1;
			// Using the while loop to print out values to string, lets the user determine it at runtimer
			while (counter < result + 1) {
				
				Console.Write (counter);
				Console.Write ("-");
				counter++;

			}
			Console.ReadLine();

		}

		private static void GuessingGame()
		{
			//Clears out the console 
			Console.Clear();

			Console.WriteLine ("Guessing Game!");

			// Creates the random number inbetween 1 and 11
			Random myRandom = new Random ();
			int randomNumber = myRandom.Next(1, 11);

			// Used to create the amount a guesses a person does
			int guesses = 0;
			bool incorrect = true;

			// Do while loop block because it Execute one time
			// use the do-while to continue to ask a seriees of questions until we get a correct answers, the do variation allows us to run our code block atleast one time oppose to jumping outside the block if the condition is true
			do {
				Console.WriteLine ("Guess a number between 1 and 10");
				string result = Console.ReadLine ();
				guesses++;
				if (result == randomNumber.ToString ())
					incorrect = false;
				else
					Console.WriteLine ("Wrong!");
			
			} 
			// While will evaluate the first time
			while (incorrect);
			Console.WriteLine ("Correct! It took you {0} guesses", guesses);



			Console.ReadLine();

		}
	}
}
