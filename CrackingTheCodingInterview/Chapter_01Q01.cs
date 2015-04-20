using System;

namespace CrackingTheCodingInterview
{
	public class Chapter_01Q01
	{
		// Implement an algorithm to determine if a string has all unique characters.
		// what if you cannot use additional data structures?
		public Chapter_01Q01 ()
		{
			string input = "";
			while (input != "quit") {
				Console.WriteLine ("Enter string to check for duplicate characters");
				// get user input as string to check
				input = Console.ReadLine ();

				var inputArray = input.ToCharArray ();
				bool duplicateFound = false;
	
				for (int i = 0; i < inputArray.Length; i++) {
					for (int j = i + 1; j < inputArray.Length; j++) {
						if (inputArray [i] == inputArray [j]) {
							Console.WriteLine ("Duplicate found: " + inputArray [j] + " at index " +
							i.ToString () + " & " + j.ToString ());
							duplicateFound = true;
						}
					}
				}

				if (duplicateFound != true)
					Console.WriteLine ("No duplicates found in string: '" + input + "'");
			}
		}
	}
}

