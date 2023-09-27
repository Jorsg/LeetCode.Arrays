using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.LinkedList
{
	public class LinkedListCycle
	{
		public LinkedListCycle()
		{

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

		//138. Copy List with Random Pointer
		//A linked list of length n is given such that each node contains an additional random pointer, which could point to any node in the list, or null.
		//Construct a deep copy of the list. The deep copy should consist of exactly n brand new nodes, where each new node has its value set to the value of its corresponding original node. Both the next and random pointer of the new nodes should point to new nodes in the copied list such that the pointers in the original list and copied list represent the same list state. None of the pointers in the new list should point to nodes in the original list.
		//For example, if there are two nodes X and Y in the original list, where X.random --> Y, then for the corresponding two nodes x and y in the copied list, x.random --> y.
		
		//Return the head of the copied linked list.
		
		//The linked list is represented in the input/output as a list of n nodes. Each node is represented as a pair of [val, random_index] where:
		//val: an integer representing Node.val
		//random_index: the index of the node (range from 0 to n-1) that the random pointer points to, or null if it does not point to any node.
		//Your code will only be given the head of the original linked list.
		
		//Example 1:
		//Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
		//Output: [[7,null],[13,0],[11,4],[10,2],[1,0]]
		public Node CopyRandomList(Node head)
		{
			//Runtime: 83 ms
			//Memory Usage: 39.9 MB
			if (head == null) return null;

			//Create a dictionary to map original nodes to their copies
			Dictionary<Node, Node> nodeMap = new Dictionary<Node, Node>();

			//Firts pass: create new nodes and map them to the original nodes
			Node current = head;
			while (current != null)
			{
				nodeMap[current] = new Node(current.val);
				current = current.next;
			}

			//Second pass: assign next and random pointers for the new nodes
			current = head;
			while (current != null)
			{
				Node copyNode = nodeMap[current];
				copyNode.next = current.next != null ? nodeMap[current.next] : null;
				copyNode.random = current.random != null ? nodeMap[current.random] : null;
				current = current.next;
			}

			//Return the head of the copied linked list
			return nodeMap[head];
		}


	}
}
