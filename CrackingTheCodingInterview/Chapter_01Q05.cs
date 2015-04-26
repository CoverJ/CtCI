using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
	public class Chapter_01Q05
	{
		//Implement a method to perform basic string compression using the counts of repeated characters.
		//aabcccccaaa would become a2blc5a3. If the "compressed" string would not become smaller
		//than the original string, your method should return the original string.

		// Psuedo code
		// 1. loop through string, for each char add +1 to the value of that key in a dictionary.
		//		if the key doesn't exist, add it to the dictionary.
		// 2. create string with key and value = "kvkvkv" where k is a key and v is a value
		// 3. return that string

		public Chapter_01Q05 ()
		{
			string input = "";
			while (input != "quit") {
				Console.WriteLine ("String to compress:");
				input = Console.ReadLine ();

				Console.WriteLine (CompressString (input));
			}
		}

		public string CompressString(string s)
		{
			var charCount = new Dictionary<char, int> ();
			string returnString = "";

			// iterate through the string either increasing the keys value by 1 or adding the key with value 1
			for (int i = 0; i < s.Length; i++) {
				if (charCount.ContainsKey (s [i])) {
					charCount [s [i]] += 1;
				} 
				else {
					charCount.Add (s [i], 1);
				}
			}

			// combine dictionary to create string to return
			foreach (KeyValuePair<char, int> kvp in charCount) {
				returnString += kvp.Key + kvp.Value.ToString ();
			}

			if (returnString.Length > s.Length)
				return s;
			else
				return returnString;
		}
	}
}

