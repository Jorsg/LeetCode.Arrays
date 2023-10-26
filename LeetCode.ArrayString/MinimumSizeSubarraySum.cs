using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class MinimumSizeSubarraySum
	{

		//209. Minimum Size Subarray Sum
		//Given an array of positive integers nums and a positive integer target, return the minimal length of a subarray whose sum is greater than or
		//equal to target. If there is no such subarray, return 0 instead.

		//Example 1:
		//Input: target = 7, nums = [2,3,1,2,4,3]
		//Output: 2
		//Explanation: The subarray [4,3] has the minimal length under the problem constraint.
		public int MinSubArrayLen(int target, int[] nums)
		{
			//Runtime: 115 ms
			//Memory: 47.1 MB
			int sum =0, minLen = nums.Length + 1;
			bool foundIt = false;
			int start = 0, end = 0;
			while (end < nums.Length)
			{
				while (sum < target && end < nums.Length)
				{
					sum += nums[end++];
				}
				while (sum>= target && start < nums.Length)
				{
					foundIt = true;
					if(end - start< minLen)
					{
						minLen= end -start;
					}
					sum -= nums[start++];
				}
			}
			if (foundIt)
			{
				return minLen;
			}

			return 0;
		}
	}
}
