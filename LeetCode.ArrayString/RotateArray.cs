using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class RotateArray
	{
		//189. Rotate Array
		//Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

		//Example 1:
		//Input: nums = [1,2,3,4,5,6,7], k = 3
		//Output: [5,6,7,1,2,3,4]
		//Explanation:
		//rotate 1 steps to the right: [7,1,2,3,4,5,6]
		//rotate 2 steps to the right: [6,7,1,2,3,4,5]
		//rotate 3 steps to the right: [5,6,7,1,2,3,4]
		public void Rotate(int[] nums, int k)
		{
			//Runtime: 153 ms
			//Memory Usage: 59.1 MB
			k %= nums.Length;
			Reverse(nums, 0, nums.Length - 1);
			Reverse(nums, 0,k -1);
			Reverse(nums, k, nums.Length -1 );

		}

		private void Reverse(int[] nums, int start, int end)
		{
			while (start < end)
			{
				(nums[start], nums[end]) = (nums[end], nums[start]);
				start++;
				end--;
			}
		}
	}
}
