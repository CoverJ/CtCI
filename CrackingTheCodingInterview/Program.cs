﻿using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//var insertionSort = new ITA_InsertionSort ();

			var linkedList = new DS_LinkedList ();
			linkedList.AddToLinkedList (1);
			linkedList.AddToLinkedList (2);
			linkedList.AddToLinkedList (3);
			linkedList.AddToLinkedList (4);
			linkedList.AddToLinkedList (5);
			linkedList.AddToLinkedList (6);
			linkedList.AddToLinkedList (7);
			linkedList.AddToLinkedList (8);
			linkedList.PrintAll ();

			//var c01q01 = new Chapter_01Q01 ();
			//var c01q02 = new Chapter_01Q02 ();
			//var c01q03 = new Chapter_01Q03 ();
			//var c01q04 = new Chapter_01Q04();
			//var c01q05 = new Chapter_01Q05();
			//var c01q06 = new Chapter_01Q06();
		}
	}
}
