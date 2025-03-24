using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
	public static class PalindromeLinkedList
	{

		//234. Palindrome Linked List
		//Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
		
		//Input: head = [1,2,2,1]
		//Output: true
		public static bool IsPalindrome(ListNode head)
		{

			//Runtime: 218 ms
			//Memory Usage: 64.6 MB
			ListNode slow = head, fast = head;
			List<int> firstHalf = new List<int>();
			while (fast != null && fast.next !=null)
			{
				firstHalf.Add(slow.val);
				slow = slow.next; 
				fast = fast.next.next;
			}
			int idx = firstHalf.Count - 1;
			if (fast != null)
				slow = slow.next;

			while (slow != null && idx > -1)
			{
				if (slow.val != firstHalf[idx]) return false;
				idx--;
				slow = slow.next;
				
			}
			return (idx == -1);
		}
	}
}
