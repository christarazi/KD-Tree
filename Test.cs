/*
https://github.com/samkitjain/PriorityQueue/blob/master/pQueue/main.cpp
https://github.com/malexandrov/PriorityQueue/blob/master/PriorityQueue.cs
https://github.com/gvd/kdtree/blob/master/kdtree.h
https://www.youtube.com/watch?v=LdaL-l2S76c
*/

using System;

namespace Tree
{
	class Test
	{
		public static void Main()
		{
			KDTree t = new KDTree(new Point(5, 5), 2);

			t.Insert(new KDNode(new Point(1, 1)), t.Root);
			t.Insert(new KDNode(new Point(0, 0)), t.Root);
			t.Insert(new KDNode(new Point(1, 2)), t.Root);
			t.Insert(new KDNode(new Point(4, 8)), t.Root);
			t.Insert(new KDNode(new Point(6, 6)), t.Root);
			t.Insert(new KDNode(new Point(7, 7)), t.Root);

			Point find = new Point(2, 2);

			KDNode found = t.NNSearch(find);

			Console.WriteLine("Nearest node to " + find.ToString() + " is " + found.Data.ToString());
		}
	}
}