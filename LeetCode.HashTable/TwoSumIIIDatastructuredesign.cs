using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.HashTable
{
	//170. Two Sum III - Data structure design
	//Design a data structure that accepts a stream of integers and checks if it has a pair of integers that sum up to a particular value.

	//Implement the TwoSum class:
		
	//TwoSum() Initializes the TwoSum object, with an empty array initially.
	//void add(int number) Adds number to the data structure.
	//boolean find(int value) Returns true if there exists any pair of numbers whose sum is equal to value, otherwise, it returns false.
	
	//Example 1:
	//Input
	//["TwoSum", "add", "add", "add", "find", "find"]
	//[[], [1], [3], [5], [4], [7]]
	//Output
	//[null, null, null, null, true, false]

	//Explanation
	//TwoSum twoSum = new TwoSum();
	//	twoSum.add(1);   // [] --> [1]
	//twoSum.add(3);   // [1] --> [1,3]
	//twoSum.add(5);   // [1,3] --> [1,3,5]
	//twoSum.find(4);  // 1 + 3 = 4, return true
	//twoSum.find(7);  // No two integers sum up to 7, return false
	internal class TwoSumIIIDatastructuredesign
	{
		//Runtime: 309 ms
		//Memory: 78.60 MB

		public List<int> nums;
		public TwoSumIIIDatastructuredesign()
		{
			nums = new List<int>();
		}

		public void Add(int number)
		{
			nums.Add(number);
		}

		public bool Find(int value)
		{
			int l = 0;
			int r = nums.Count() - 1;
			nums.Sort();
			while (l < r)
			{
				int target = nums[l] + nums[r];
				if (target == value)
					return true;
				else if (target > value)
					r--;
				else
					l++;
			}
			return false;
		}
	}
}
