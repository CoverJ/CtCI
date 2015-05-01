using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
	// Given an image represented by an N x N matrix, where each pixel of
	// the image is 4 bytes, write a method to rotate the images
	// 90 degress. Can you do this in place?	
	public class Chapter_01Q06
	{
		// test matrix - working
		/*int[,] matrix = new int[9, 9] { {1,2,3,4,5,6,7,8,9}, {1,2,3,4,5,6,7,8,9}, {1,2,3,4,5,6,7,8,9}, {1,2,3,4,5,6,7,8,9}, 
			{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9},{1,2,3,4,5,6,7,8,9}};*/
		int n = 4;
		int[,] m2 = new int[4,4] { {1,2,3,4}, {1,2,3,4}, {1,2,3,4}, {1,2,3,4} };
	
		public Chapter_01Q06 ()
		{
			PrintMatrix (m2);
			Console.WriteLine ();
			RotateMatrix (m2, n);
			Console.WriteLine ();
			RotateMatrix (m2, n);
			Console.WriteLine ();
			RotateMatrix (m2, n);
			Console.WriteLine ();
			RotateMatrix (m2, n);

		}

		// 1 2 3 4 5  1 1 1 1 1  1 2 3 4  1 1 1 1  0 0 0 0  3 2 1 0
		// 1 2 3 4 5  2 2 2 2 2  1 2 3 4  2 2 2 2  1 1 1 1  3 2 1 0
		// 1 2 3 4 5  3 3 3 3 3  1 2 3 4  3 3 3 3  2 2 2 2  3 2 1 0
		// 1 2 3 4 5  4 4 4 4 4  1 2 3 4  4 4 4 4  3 3 3 3  3 2 1 0
		// 1 2 3 4 5  5 5 5 5 5

		private void RotateMatrix(int[,] matrix, int n)
		{			
			for (int layer = 0; layer < n / 2; layer++) {
				int first = layer;
				int last = n - 1 - layer;

				for (int i = first; i < last; i++) {
					int offset = i - first;
					// save top rows value, this lets us perform the operation in place, using O(1) memory instead of O(n)
					int top = matrix [first, i];

					// lhs to top
					matrix[first, i] = matrix[last - offset, first];
					// bottom to lhs
					matrix[last-offset, first] = matrix[last, last-offset];
					// rhs to bottom
					matrix[last,last-offset] = matrix [i, last];
					// top to rhs aka put in the previously saved value.
					matrix[i, last] = top;
				}
			}

			PrintMatrix (matrix);
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

