using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public static class ContainsDuplicate
	{
		//217. Contains Duplicate
		//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

		//Example 1:
		//Input: nums = [1,2,3,1]
		//Output: true
		public static bool ContainsDuplicateExcer(int[] nums)
		{
			//Runtime: 183 ms
			//Memory Usage: 55.3 MB
			HashSet<int> result = new HashSet<int>();
            foreach (var item in nums)
            {
				if (result.Contains(item))
					return true;
				else
					result.Add(item);				
            }
            return false;
		}
	}
}
