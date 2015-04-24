using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
	// Given an image represented by an N x N matrix, where each pixel of
	// the image is 4 bytes, write a method to rotate the images
	// 90 degress. Can you do this in place?	
	public class Chapter_01Q06
	{
		public Chapter_01Q06 ()
		{
			ProduceMatrix ();
		}

		// 1 2 3 4 5  1 1 1 1 1  1 2 3 4  1 1 1 1  0 0 0 0  3 2 1 0
		// 1 2 3 4 5  2 2 2 2 2  1 2 3 4  2 2 2 2  1 1 1 1  3 2 1 0
		// 1 2 3 4 5  3 3 3 3 3  1 2 3 4  3 3 3 3  2 2 2 2  3 2 1 0
		// 1 2 3 4 5  4 4 4 4 4  1 2 3 4  4 4 4 4  3 3 3 3  3 2 1 0
		// 1 2 3 4 5  5 5 5 5 5

		private void ProduceMatrix()
		{			
			var matrix = new int[4, 4] { {1,2,3,4}, {1,2,3,4}, {1,2,3,4}, {1,2,3,4} };
			var newMatrix = new int[4, 4];

			// rotate matrix
			// 0,0 > 0,3  // 1,0 > 0,2    // 0,0 > 0,3  // 0,1 > 1,3
			// 0,1 > 1,3  // 1,1 > 1,2    // 1,0 > 0,2  // 1,1 > 1,2
			// 0,2 > 2,3  // 1,2 > 2,2    // 2,0 > 0,1  // 2,1 > 1,1
			// 0,3 > 3,3  // 1,3 > 3,2    // 3,0 > 0,0  // 3,1 > 1,0

			for (int i = 0; i < 4; i++) { // rows
				for (int j = 0; j < 4; j++) { // columns
					newMatrix[i,j] = matrix[j, (i - 1) % 4];
				}
			}
			PrintMatrix (matrix);
			Console.WriteLine ();
			PrintMatrix (newMatrix);
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

