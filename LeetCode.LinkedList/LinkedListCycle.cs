using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
	public class LinkedListCycle
	{
		private ListNode _head;

		public LinkedListCycle()
		{
			_head = null;
		}


		//Linked List Cycle
		//Given head, the head of a linked list, determine if the linked list has a cycle in it.
		//There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.
		//Internally, pos is used to denote the index of the node that tail's next pointer is connected to.
		//Note that pos is not passed as a parameter.

		//Example 1:
		//Input: head = [3,2,0,-4], pos = 1
		//Output: true
		//Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).

		//Example 2:
		//Input: head = [1,2], pos = 0
		//Output: true
		//Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.

		public bool HasCycle(ListNode head)
		{
			//Runtime: 100 ms
			//Memory Usage: 44.4 MB
			HashSet<ListNode> visited = new HashSet<ListNode>();
			while (head != null)
			{
				if (visited.Contains(head))
				{
					return true;
				}
				visited.Add(head);
				head = head.next;
			}
			return false;
		}


		//Linked List Cycle II
		//Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.
		//There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed). It is -1 if there is no cycle. Note that pos is not passed as a parameter.
		//Do not modify the linked list.
		//Example 1:
		//Input: head = [3,2,0,-4], pos = 1
		//Output: tail connects to node index 1
		//Explanation: There is a cycle in the linked list, where tail connects to the second node.
		public ListNode DetectCycle(ListNode head)
		{
			//Runtime: 78 ms
			//Memory Usage: 41.7 MB
			HashSet<ListNode> nodeSeen = new HashSet<ListNode>();
			ListNode node = head;

			while (node != null)
			{
				if (nodeSeen.Contains(node))
				{
					return node;
				}
				else
				{
					nodeSeen.Add(node);
					node = node.next;
				}
			}

			return null;
		}


		//Remove Nth Node From End of List
		//Given the head of a linked list, remove the nth node from the end of the list and return its head.
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{

			//Runtime : 81 ms
			//Memory : 38.82

			ListNode currentNode = head;
			for (int i = 0; i < n; i++)
			{
				currentNode = currentNode.next;
			}
			if (currentNode == null)
			{
				return head.next;
			}
			ListNode nodoBeforeRemoved = head;
			while (currentNode.next != null)
			{
				currentNode = currentNode.next;
				nodoBeforeRemoved = nodoBeforeRemoved.next;
			}
			nodoBeforeRemoved.next = nodoBeforeRemoved.next.next;

			return head;
		}

		
	}
}
