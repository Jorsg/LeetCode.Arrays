using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.QueueStack
{
	internal class MyCircularQueue
	{
		int[] q;
		int front =0, rear = -1, count = -0, capacity = 0;
		public MyCircularQueue(int k)
		{
			capacity = k;
			q = new int[k];
		}

		public bool EnQueue(int value)
		{ 
			if(IsFull())
				return false;
			else
			{
				rear = (rear + 1) % capacity;
				q[rear] = value;
				count++;
				return true;
			}
		}

		public bool DeQueue()
		{
			if (IsEmpty())
				return false;
            else
            {
                front= (front + 1) % capacity;
				count = count - 1 < 0 ? 0 : count -1;
				return true;
            }
        }

		public int Front()
		{
			return IsEmpty() ? -1 : q[front];
		}

		public int Rear()
		{
			return IsEmpty() ? -1 : q[rear];
		}

		public bool IsEmpty()
		{
			return count == 0;
		}

		public bool IsFull()
		{
			return count == capacity;
		}
	}
}
