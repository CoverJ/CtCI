using System;
using System.Collections.Generic;
namespace CrackingTheCodingInterview
{
	public class Chapter_02Q01
	{
		// write code to remove duplicates from an unsorted linked list
		// part 2: How would you solve this if a temporary buffer is not allowed?

		LinkedList<int> ll = new LinkedList<int> (); //{1,3,5,3,5,0,9,3};

		public Chapter_02Q01 ()
		{
			ll.AddFirst (1);
			ll.AddLast (3);
			ll.AddLast (5);
			ll.AddLast (3);
			ll.AddLast (7);
			ll.AddLast (0);
			ll.AddLast (9);
			ll.AddLast (3);
			printLinkedList (ll);
			RemoveDuplicates (ll);
			Console.WriteLine ();
			printLinkedList (ll);
		}

		public void printLinkedList(LinkedList<int> a) {
			string s = "";
			LinkedListNode<int> node = a.First;

			foreach (var n in a) {
				s += n.ToString ();
			}
			Console.WriteLine (s);
		}

		public void RemoveDuplicates(LinkedList<int> a)
		{
			List<LinkedListNode<int>> duplicates = new List<LinkedListNode<int>> ();
			List<LinkedListNode<int>> toRemove = new List<LinkedListNode<int>> ();
			LinkedListNode<int> node = a.First;
			foreach (var n in a) {
				if (node.Value == n) {
					toRemove.Add (node);
				}
				else {
					duplicates.Add (node);
				}
				node = node.Next;
			} 

				
			for (int i = 0; i < toRemove.Count; i++) {
				LinkedListNode<int> n = toRemove [i];
				a.Remove (n);
			}
		}
	}
}

