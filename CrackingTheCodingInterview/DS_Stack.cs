using System;

namespace CrackingTheCodingInterview
{
	public class DS_Stack
	{
		public int[] stack;
		private int key;

		public DS_Stack ()
		{
			stack = new int[10];
			key = 0;
		}

		public void Push(int value)
		{
			stack [key] = value;
			key++;
		}

		public int Pop()
		{
			int value = Peek ();
			key--;
			return value;
		}

		public int Peek()
		{
			return stack [key];
		}
	}
}

