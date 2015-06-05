using System;

namespace CrackingTheCodingInterview
{
	public class Sort_Insertion
	{
		public Sort_Insertion ()
		{
			// 3 2 1
			int[] numbers = {3,1,9,2,6,7,4,8,5};
			Sort (numbers);
		}

		public static void Sort(int[] _array)
		{
			for (int i = 1; i < _array.Length; i++) {
				int temp = _array [i];
				int index = i;

				while (index > 0 && _array [index - 1] > temp) { // > _array[i]
					_array[index] = _array[index - 1];
					index--;
				}
				_array [index] = temp;

				for (int a = 0; a < _array.Length; a++) {
					Console.Write (_array[a].ToString());
				}
				Console.WriteLine ();
			}
		}
	}
}

