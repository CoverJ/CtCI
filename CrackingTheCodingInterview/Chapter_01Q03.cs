using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
	public class Chapter_01Q03
	{
		public Chapter_01Q03 ()
		{
			// Given two string write a method to decide if one is a permutation of the other
			string input1 = "";
			string input2 = "";

			var longestWordDictionary = new Dictionary<char, int> ();
			var shorterWordDictionary = new Dictionary<char, int> ();

			bool permutation = true;

			while (input1 != "quit") {
				Console.WriteLine ("Enter first string");
				input1 = Console.ReadLine ().ToLower();
				Console.WriteLine ("Enter second string");
				input2 = Console.ReadLine ().ToLower();

				if (input1.Length >= input2.Length) {
					longestWordDictionary = stringToDictionary (input1);
					shorterWordDictionary = stringToDictionary (input2);
				} else {
					longestWordDictionary = stringToDictionary (input2);
					shorterWordDictionary = stringToDictionary (input1);
				}

				foreach (KeyValuePair<char,int> kvp in shorterWordDictionary) {
					try{
						if (kvp.Value > longestWordDictionary[kvp.Key]) {
							permutation = false;
						}
					}
					catch {
						permutation = false;

					}
				}

				if (permutation == true)
					Console.WriteLine ("Permutation is true");
				else
					Console.WriteLine ("Permutation is false");
			}
		}

		private Dictionary<char,int> stringToDictionary (string s){
			var charDict = new Dictionary<char,int> ();

			foreach (char c in s) {
				if (charDict.ContainsKey (c)) {
					charDict [c] = charDict[c] + 1;
				}
				else {
					charDict.Add (c, 1);
				}
			}

			return charDict;
		}
	}
}

