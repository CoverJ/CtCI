using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
	public class DS_LinkedList
	{
		public LinkedList<int> ll;
		public Node head { get; set; }
		public Node tail { get; set; }
		public int length = 0;

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
			length++;
		}

		// Removes element by adjusting 'next' values. I don't think this would actually remove items from memory.
		public bool RemoveFromLinkedList(int value)
		{
			Node current = head;

			if (current.Value == value) {
				head = current.next;
				return true;
			}
			while (current != null) {
				if (current.next.Value == value) {
					current.next = current.next.next;
					return true;
				}
				current = current.next;
			}
			return false;
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

