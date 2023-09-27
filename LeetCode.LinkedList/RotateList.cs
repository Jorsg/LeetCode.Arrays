using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
	public class RotateList
	{
		//61. Rotate List
		//Given the head of a linked list, rotate the list to the right by k places.

		//Example 1:
		//Input: head = [1,2,3,4,5], k = 2
		//Output: [4,5,1,2,3]
		public ListNode RotateRight(ListNode head, int k)
		{
			//Runtime: 77 ms
			//Memory Usage: 39.6 MB
			if (head == null) return null;

			var length = 1;
			var tail = head;

			while (tail.next != null)
			{
				length++;
				tail = tail.next;
			}
			tail.next = head;
			k = length - k % length;
			for (int i = 0; i < k; i++)
			{
				head = head.next;
				tail = tail.next;
			}
			tail.next = null;
			return head;
		}
	}
}
