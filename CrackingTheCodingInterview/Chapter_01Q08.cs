using System;

namespace CrackingTheCodingInterview
{
	public class Chapter_01Q08
	{
		// Given 2 strings s1 and s2, write code to check if s2 is a rotation of s1 using only one call of 'isRotation'
		// eg 'waterbottle' is a rotation of 'erbottlewat'
		public Chapter_01Q08 ()
		{
			bool b1 = isSubstring ("john", "ron");
			Console.WriteLine(b1.ToString());
			Console.WriteLine();
			bool b2 = isSubstring ("waterbottle", "erbottlewat");
			Console.WriteLine (b2.ToString ());
		}

		public bool isSubstring(string s1, string s2) {
			if (s1.Length != s2.Length)
				return false;
			if (string.IsNullOrEmpty (s1) || string.IsNullOrEmpty (s2))
				return false;

			for (int i = 1; i < s1.Length; i++) {
				string a = s2.Substring (i);
				string b = s2.Substring (0, i);

				Console.WriteLine (a + b + "  " + b + a);

				if (a + b == s1 || b + a == s1)
					return true;
			}
			return false;
		}
	}
}

