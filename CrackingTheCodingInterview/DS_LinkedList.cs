using System;

namespace CrackingTheCodingInterview
{
	public class DS_LinkedList
	{
		public Node head { get; set; }
		public Node tail { get; set; }

		public void AddToLinkedList(int value)
		{
			var node = new Node ();
			node.Value = value;

			if (head == null) {
				head = node;
				tail = node;
			}
			else {
				node.next = head;
				head = node;
			}
		}

		public void PrintAll()
		{
			Node current = head;
			while (current != null) {
				Console.WriteLine (current.Value.ToString ());
				current = current.next;
			}
		}
	}
	public class Node
	{
		public int Value;
		public Node next;
	}
}

