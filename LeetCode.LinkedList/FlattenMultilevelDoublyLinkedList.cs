using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.LinkedList
{
	

	//430. Flatten a Multilevel Doubly Linked List
	//You are given a doubly linked list, which contains nodes that have a next pointer, a previous pointer, and an additional child pointer. This child pointer may or may not point to a separate doubly linked list, also containing these special nodes.
	//These child lists may have one or more children of their own, and so on, to produce a multilevel data structure as shown in the example below.
	//Given the head of the first level of the list, flatten the list so that all the nodes appear in a single-level, doubly linked list.Let curr be a node with a child list.
	//The nodes in the child list should appear after curr and before curr.next in the flattened list.
	//Return the head of the flattened list.The nodes in the list must have all of their child pointers set to null.
	public class FlattenMultilevelDoublyLinkedList
	{
		public Node Flatten(Node head)
		{
			//Runtime: 86 ms
			//Memory: 38.72 MB
			Traverse(head);
			return head;
		}

		private Node Traverse(Node head)
		{
			Node node = head;
			Node tempNode, parentNode;
			while (node != null && (node.child != null || node.next != null))
			{
				if (node.child != null)
				{
					parentNode = node;
					tempNode = node.next;
					node.next = node.child;
					node.child = null; // Setting the child node to null.
					node = node.next; // Moving the curr node to child node.
					node.prev = parentNode; // Setting parent node as previous node.
					node.next = Traverse(node);
					node.next = tempNode;
					if (tempNode != null)
					{
						tempNode.prev = node; // Setting current node as tempNode's prev node.
					}
				}
				if (node.next != null)
				{
					node = node.next;
				}
			}
			return node;
		}

		//708 Insert into a Cyclic Sorted List
		//Given a Circular Linked List node, which is sorted in non-descending order, write a function to insert a value insertVal into the list such that it remains a sorted circular list. The given node can be a reference to any single node in the list and may not necessarily be the smallest value in the circular list.

		//If there are multiple suitable places for insertion, you may choose any place to insert the new value.After the insertion, the circular list should remain sorted.

		//If the list is empty (i.e., the given node is null), you should create a new single circular list and return the reference to that single node.Otherwise, you should return the originally given node.
		public Node Insert(Node head, int insertVal)
		{
			//Runtime: 86 ms
			//Memory Usage: 39.8 MB
			Node nod = new Node(insertVal);
			if (head == null)
			{
				nod.next = nod;
				return nod;
			}
			else
			{
				var n = head;
				while (n.next != head)
				{
					if ((insertVal >= n.val && insertVal <= n.next.val) ||
						(insertVal <= n.val && insertVal <= n.next.val && n.val > n.next.val) ||
						(n.val > n.next.val && (insertVal >= n.val || insertVal < n.next.val))
						)
					{
						nod.next = n.next;
						n.next = nod;
						return head;
					}
					n = n.next;
				}
				nod.next = n.next;
				n.next = nod;
			}
			return head;
		}
	}
}
