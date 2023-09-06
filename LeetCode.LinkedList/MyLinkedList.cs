using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LinkedList
{
	//Runtime: 155 ms
	//Memory Usage: 62.2 MB
	public class MyLinkedList
	{
		private ListNode _head;
		private int _count = 0;


		public MyLinkedList()
		{
			_head = null;


		}

		public int Get(int index)
		{
			if (index >= _count || index < 0 || _count == 0)
				return -1;

			var curr = _head;

			while (curr != null && index > 0)
			{
				curr = curr.Next;
				index--;
			}

			return curr == null ? -1 : curr.Val;
		}

		public void AddAtHead(int val)
		{
			_head = new ListNode() { Val = val, Next = _head };
			_count++;
		}

		public void AddAtTail(int val)
		{
			var node = new ListNode() { Val = val };

			if (_head == null)
				_head = node;
			else
			{
				var curr = _head;

				while (curr.Next != null)
					curr = curr.Next;

				curr.Next = node;
			}
			_count++;
		}

		public void AddAtIndex(int index, int val)
		{
			if (index > _count || index < 0) return;

			if (index == 0)
				AddAtHead(val);
			else if (index == _count)
				AddAtTail(val);
			else
			{
				//int i = 0;
				var curr = _head;

				while (curr != null && index - 1 > 0)
				{
					curr = curr.Next;
					index--;
				}

				var temp = curr.Next;
				curr.Next = new ListNode() { Val = val, Next = temp };
			}

			_count++;
		}

		public void DeleteAtIndex(int index)
		{
			if (index >= _count || index < 0 || _count == 0) return;

			if (index == 0)
				_head = _head.Next;
			else
			{
				//int i = 0;
				var curr = _head;

				while (curr != null && index - 1 > 0)
				{
					curr = curr.Next;
					index--;
				}

				curr.Next = curr.Next?.Next;
			}

			_count--;
		}

	}
}
