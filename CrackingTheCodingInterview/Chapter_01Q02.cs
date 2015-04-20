using System;

namespace CrackingTheCodingInterview
{
	public class Chapter_01Q02
	{
		// reverse a null terminated string
		public Chapter_01Q02 ()
		{
			string input = "";
			while (input != "0") {
				Console.WriteLine ("Enter string to be reversed:");
				input = Console.ReadLine ();

				// add '0' as the terminating char of a string
				input += "0";

				// reverse string
				int end = input.Length - 2;
				string output = "";
				while (end >= 0) {
					output += input [end];
					end--;
				}

				// output the reversed string
				Console.WriteLine(output);
			}
		}
	}
}

