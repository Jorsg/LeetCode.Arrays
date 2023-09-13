using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
	public class ReverseLinkedList
	{
		//206. Reverse Linked List
		//Given the head of a singly linked list, reverse the list, and return the reversed list.
		//Input: head = [1,2,3,4,5]
		//Output: [5,4,3,2,1]

		public ListNode ReverseList(ListNode head)
		{
			ListNode previNode = null;
			ListNode currentNode = head;
			while (currentNode != null)
			{
				ListNode nextiNode = currentNode.next;// Swap
				currentNode.next = previNode;
				previNode = currentNode;
				currentNode = nextiNode;
			}

			return previNode;
		}


		//203. Remove Linked List Elements
		//Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
		public ListNode RemoveElements(ListNode head, int val)
		{
			//Runtime: 82 ms
			// Memory: 42.33 MB
			ListNode sentinel = new ListNode();
			ListNode prev = sentinel, curNod = head;

			sentinel.next = head;
			while (curNod != null)
			{
				if (curNod.val == val)
					prev.next = curNod.next;
				else
					prev = curNod;

				curNod = curNod.next;
			}

			return sentinel.next;
		}
	}
}
