using System;

namespace CrackingTheCodingInterview
{
	public class Chapter_01Q04
	{
		// Write a method to replace all spaces in a string with '%20'
		// "Mr John Smith" = "Mr%20John%20Smith"

		int spaceCount = 0;
		string input = "";
		public Chapter_01Q04 ()
		{
			while (input != "quit") {
				Console.WriteLine ("Enter string");
				input = Console.ReadLine ();

				//Console.WriteLine(usingReplace(input));
				Console.WriteLine (withoutUsingReplace (input));
			}
		}

		public string usingReplace(string s)
		{
			string a = s.Replace (" ", "%20");
			return a;
		}

		public string withoutUsingReplace(string s)
		{
			// count the number of spaces in the string
			foreach (char c in s) {
				if (c == ' ')
					spaceCount++;
			}

			int newArraySize = s.Length + spaceCount * 2;
			var charArray = new char[newArraySize];
			int indexOffset = 0;

			for (int i = 0; i < s.Length; i++) {
				if (s [i] == ' ') {
					charArray [i + indexOffset] = '%';
					charArray [i + indexOffset + 1] = '2';
					charArray [i + indexOffset + 2] = '0';
					indexOffset += 2;
				} else
					charArray [i + indexOffset] = s [i];
			}
			string re = "";
			foreach (char c in charArray) {
				re += c;
			}
			return re;
		}
	}
}

