using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
	
	class ReverseLinkedListII
	{
		public ListNode ReverseBetween(ListNode head, int left, int right)
		{
			if (head == null || left == right)
			{
				return head;
			}

			ListNode dummy = new ListNode(0);
			dummy.next = head;
			ListNode prev = dummy;

			for (int i = 1; i < left; i++)
			{
				prev = prev.next;
			}

			ListNode current = prev.next;
			ListNode next = null;

			for (int i = left; i < right; i++)
			{
				next = current.next;
				current.next = next.next;
				next.next = prev.next;
				prev.next = next;
			}
			return dummy.next;
		}
	}
}
