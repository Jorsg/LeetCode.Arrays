using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{	
	public class MyHashMap
	{
		int[] a;
		MyHashMap()
		{
			a = new int[1000001];
			Array.Fill(a,-1);
		}

		void put(int key, int value)
		{
			a[key] = value;
		}

		int get(int key)
		{
			return a[key];
		}

		void remove(int key)
		{
			a[key]= -1;
		}

	}
}
