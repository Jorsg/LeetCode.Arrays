using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public static class SingleNumber
	{
		//136. Single Number
		//Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
		//You must implement a solution with a linear runtime complexity and use only constant extra space.

		//Example 1:
		//Input: nums = [2,2,1]
		//Output: 1
		public static int SingleNumberExcer(int[] nums)
		{
			//Runtime: 107 ms
			//Memory Usage: 43.9 MB
			int single = 0;
			for (int i = 0; i < nums.Length; i++)
			{

				single ^= nums[i]; // XOR

			}

			return single;
		}
	}
}
