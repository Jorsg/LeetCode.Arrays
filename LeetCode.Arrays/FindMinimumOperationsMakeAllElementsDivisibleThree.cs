using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Arrays
{
	public static class FindMinimumOperationsMakeAllElementsDivisibleThree
	{
		//3190. Find Minimum Operations to Make All Elements Divisible by Three
		//You are given an integer array nums. In one operation, you can add or subtract 1 from any element of nums.		
		//Return the minimum number of operations to make all elements of nums divisible by 3.
		
		//Example 1:		
		//Input: nums = [1, 2, 3, 4]
		//Output: 3
		//Explanation:
		//All array elements can be made divisible by 3 using 3 operations:
		
		//Subtract 1 from 1.
		//Add 1 to 2.
		//Subtract 1 from 4.

		//Example 2:
		//Input: nums = [3, 6, 9]
		//Output: 0

		
		//Constraints:
		
		//1 <= nums.length <= 50
		//1 <= nums[i] <= 50
		public static int MinimumOperations(int[] nums)
		{
			int total = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] % 3 == 0)
					total += 0;
				else if (nums[i] % 3 == 1)
					total++;
				else if (nums[i] % 3 == 2)
					total++;
			}
			return total;
		}
	}
}
