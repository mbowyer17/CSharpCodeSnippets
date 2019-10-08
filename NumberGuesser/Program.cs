using System;

// Name space
namespace Beginners_Course
{
	//Main Class
	class MainClass
	{
		
		// Entry Point Method
		static void Main (string[] args)
		{
			// Run GetsAppInfo to get info
			GetAppInfo();

			GetAppIntro ();

			//Repeat Game
			while (true) {
				
			
				// Set a Random Correct number
				Random random = new Random ();
				int correctNumber = random.Next (1, 10);
				//Console.WriteLine (correctNumber);

				// Initiate Guess Variable
				int guessNumber = 0;

				// Ask user for number
				Console.WriteLine ("Guess the number I'm thinking of between 1 and 10");

				// While guess is no correct
				while (guessNumber != correctNumber) {
					//Gets user input
					string input = Console.ReadLine ();

					//Make sure its a number
					if (!int.TryParse (input, out guessNumber)) {

						//Print error message
						PrintColourMessage(ConsoleColor.Red, "Please use an actual number");

						// Keep going 
						continue;
					}


					// Cast to int and put in guess
					guessNumber = Int32.Parse (input);

					// Match Guess to correct number
					if (guessNumber != correctNumber) {

						// Prints error message
						PrintColourMessage(ConsoleColor.Red, "Incorrect number, please try again");

					}
				}

				// Prints success message
				PrintColourMessage(ConsoleColor.Yellow, "You are correct!!!");

				// Ask to play Again 
				Console.WriteLine ("Play Again? Y or N");

				// Get Answer
				string answer = Console.ReadLine().ToUpper();
				if (answer == "Y") {
					continue;
				} else if (answer == "N") {
					return;
				}
				else
				{
					return;				
				}

			}
		}

		//Get and display App info
		static void GetAppInfo(){
			// Set app variables
			string appName = "Number Guesser";
			string appVersion = "1.0.0";
			string appAuthor = "Matthew Bowyer";

			// Change text color
			Console.ForegroundColor = ConsoleColor.Green;

			// Write out app info
			Console.WriteLine ("Name: {0}\nVerison: {1}\nAuthor: {2}", appName, appVersion, appAuthor);

			// Reset text
			Console.ResetColor ();
		}

		static void GetAppIntro(){
			// Ask Users name
			Console.WriteLine("What is your name? ");

			// Get user input
			string inputName = Console.ReadLine();

			// Game
			Console.WriteLine ("Hello {0}, lets play a game.",inputName);
		
		}

		// Print colour message
		static void PrintColourMessage(ConsoleColor color, string message){
			// Change text color
			Console.ForegroundColor = color;

			// 	Tells user its not a number
			Console.WriteLine (message);

			// Reset text
			Console.ResetColor ();
		}
	}
}
