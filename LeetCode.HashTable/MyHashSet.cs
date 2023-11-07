using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public class MyHashSet
	{
		//705. Design HashSet

		//Runtime: 195 ms
		//Memory Usage: 69.6 MB
		BitArray arr;
		public MyHashSet()
		{
			arr = new BitArray(1000001);
		}

		public void Add(int key)
		{
			arr[key] = true;
		}

		public void Remove(int key)
		{
			arr[key] = false;
		}

		public bool Contains(int key)
		{
			return arr[key];
		}
	}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
}
