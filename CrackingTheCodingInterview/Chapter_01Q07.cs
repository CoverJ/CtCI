using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
	// Write an algorithm such that if an element of an MxN matrix is 0, its entire row and column are set yo 0.
	public class Chapter_01Q07
	{
		Dictionary<char, List<int>> rclist = new Dictionary<char, List<int>>();
		int[,] matrix = new int[3,5] { {1,0,3,4,5}, {1,2,3,0,5}, {1,2,3,4,5} };

		int height = 3;//matrix.GetLength (0);
		int length = 5;//matrix.GetLength (1);

		public Chapter_01Q07 ()
		{
			PrintMatrix (matrix);
			rclist = FindRowsCols (matrix);
			matrix = ZeroRowsCols (matrix, rclist);
			Console.WriteLine ();
			PrintMatrix (matrix);
		}

		public Dictionary<char,List<int>> FindRowsCols(int[,] matrix)
		{
			var reDict = new Dictionary<char, List<int>> ();
			reDict.Add('r', new List<int>());
			reDict.Add ('c', new List<int> ());

			for (int i = 0; i < height; i++) {
				for (int j = 0; j < length; j++) {
					if (matrix[i,j] == 0) {
						
						if (!reDict['r'].Contains(i))
							reDict ['r'].Add (i);
						
						if (!reDict['c'].Contains(j))
							reDict ['c'].Add (j);
					}
				}
			}

			return reDict;
		}

		public int[,] ZeroRowsCols(int[,] matrix, Dictionary<char, List<int>> dic)
		{
			for (int i = 0; i < height; i++) {
				for (int j = 0; j < length; j++) {
					if (dic['r'].Contains(i) || dic['c'].Contains(j)) {
						matrix [i, j] = 0;
					}
				}
			}
			return matrix;
		}

		private void PrintMatrix(int[,] a)
		{
			int rowLength = a.GetLength (0);
			int columnLength = a.GetLength (1);
			// print matrix
			for (int i = 0; i < rowLength; i++) {
				for (int j = 0; j < columnLength; j++) {
					Console.Write(a[i,j].ToString() + " ");
				}
				Console.WriteLine ();
			}
		}
	}
}

