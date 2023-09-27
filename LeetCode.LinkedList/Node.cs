using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
	public class Node
	{
		public int val;
		public Node prev;
		public Node next;
		public Node child;
		public Node random;

		public Node() { }

		public Node(int _val)
		{
			val = _val;
			next = null;
		}

		public Node(int _val, Node _next, Node random)
		{
			val = _val;
			next = _next;
			this.random = random;
		}
	}
}
