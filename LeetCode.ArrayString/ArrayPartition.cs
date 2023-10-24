using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class ArrayPartition
	{
		//561. Array Partition
		//Given an integer array nums of 2n integers, group these integers into n pairs (a1, b1), (a2, b2), ..., (an, bn) such that the sum of min(ai, bi).
		//for all i is maximized. Return the maximized sum.

		//Example 1:
		//Input: nums = [1,4,3,2]
		//Output: 4
		//Explanation: All possible pairings (ignoring the ordering of elements) are:
		//1. (1, 4), (2, 3) -> min(1, 4) + min(2, 3) = 1 + 2 = 3
		//2. (1, 3), (2, 4) -> min(1, 3) + min(2, 4) = 1 + 2 = 3
		//3. (1, 2), (3, 4) -> min(1, 2) + min(3, 4) = 1 + 3 = 4
		//So the maximum possible sum is 4.
		public int ArrayPairSum(int[] nums)
		{
			//Runtime: 118 ms
			//Memory Usage: 50.4 MB

			Array.Sort(nums);
			int maxSum = 0;
			for (int i = 0; i < nums.Length; i += 2)
			{
				maxSum += nums[i];
			}

			return maxSum;
		}
	}
}
