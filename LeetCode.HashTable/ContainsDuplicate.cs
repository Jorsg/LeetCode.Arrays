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


		//219. Contains Duplicate II
		//Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

		//Example 1:
		//Input: nums = [1,2,3,1], k = 3
		//Output: true

		//Example 2:
		//Input: nums = [1,0,1,1], k = 1
		//Output: true
		public static bool ContainsNearbyDuplicate(int[] nums, int k)
		{

			//Runtime: 571 ms
			//Memory Usage: 58.3 MB
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = Math.Max(i - k, 0); j < i; j++)
				{
					if (nums[i] == nums[j]) return true;

				}
			}
			return false;
		}
	}
}
