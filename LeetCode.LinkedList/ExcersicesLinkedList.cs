using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.LinkedList
{
	public class ExcersicesLinkedList
	{
		//2. Add Two Numbers
		//You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit.
		//Add the two numbers and return the sum as a linked list.
		//You may assume the two numbers do not contain any leading zero, except the number 0 itself.
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			//Runtime: 88 ms
			//Memory Usage: 49.7 MB
						ListNode tempHead = new ListNode();
			ListNode current = tempHead;
			int carry = 0;
			
			while (l1 != null || l2 != null || carry != 0)
			{
				int x = (l1 != null) ? l1.val : 0;
				int y = (l2 != null) ? l2.val : 0;
				int sum = carry + x + y;
				carry = sum / 10;
				current.next = new ListNode(sum % 10);
				current = current.next;
				if (l1 != null)
				{
					l1 = l1.next;
				}
				if (l2 != null)
				{
					l2 = l2.next;
				}
			}


			return tempHead.next;
		}


		//For
		//Given head which is a reference node to a singly-linked list. The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.
		//Return the decimal value of the number in the linked list.
		//The most significant bit is at the head of the linked list.

		//Example 1:
		//Input: head = [1,0,1]
		//Output: 5
		//Explanation: (101) in base 2 = (5) in base 10
		
		public int GetDecimalValue(ListNode head)
		{
			//Runtime: 80 ms
			//Memory: 37.88 MB
			int result = 0;
			while (head != null)
			{
				result = result * 2 + head.val;
				head = head.next;
			}
			return result;
		}
	}
}
