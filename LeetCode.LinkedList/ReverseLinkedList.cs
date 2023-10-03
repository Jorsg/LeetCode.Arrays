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
				ListNode tempNod = currentNode.next;// Swap
				currentNode.next = previNode;
				previNode = currentNode;
				currentNode = tempNod;
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

		//82. Remove Duplicates from Sorted List II
		//Given the head of a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list. Return the linked list sorted as well.
		//Input: head = [1,2,3,3,4,4,5]
		//Output: [1,2,5]
		public ListNode DeleteDuplicates(ListNode head)
		{
			//Runtime: 80 ms
			// Memory: 39.87 MB
			ListNode newHead = new ListNode(0, head);
			var prevNod = newHead;

			while (prevNod != null)
			{
				if (prevNod.next != null && prevNod.next.next != null && prevNod.next.val == prevNod.next.next.val)
				{
					var duplicaNod = prevNod.next.val;
					while (prevNod.next != null && prevNod.next.val == duplicaNod) prevNod.next = prevNod.next.next;
				}
				else
					prevNod = prevNod.next;			
			}
			return newHead.next;
		}
	}
}
