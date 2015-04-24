using System;

namespace CrackingTheCodingInterview
{
	public class ITA_InsertionSort
	{
		public ITA_InsertionSort ()
		{
			var A = new int[]{ 5,9,1,3,2,7,4,6,8 };
			InsertionSort (A);
		}

		public void InsertionSort(int[] A)
		{
			// this for loop moves the key along
			for (int i = 1; i < A.Length; i++) {
				var key = A [i];
				var compare = i - 1;

				while (compare >= 0 && A[compare] > key) {
					A [compare + 1] = A [compare];
					compare = compare - 1;
				}
				A [compare + 1] = key;
			}
			Console.WriteLine (PrintArray (A));
		}

		public string PrintArray(int[] A) {
			string prnt = "";
			for (int k = 0; k < A.Length; k++) {
				prnt += A [k].ToString ();
			}
			return prnt;
		}
	}
}

