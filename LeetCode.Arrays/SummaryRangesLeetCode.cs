using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public class SummaryRangesLeetCode
	{
		//228. Summary Ranges
		//You are given a sorted unique integer array nums.
		//Return the smallest sorted list of ranges that cover all the numbers in the array exactly.
		//That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.
		//Each range [a,b] in the list should be output as:
		//"a->b" if a != b
		//"a" if a == b
		//Example 1:
		//Input: nums = [0,1,2,4,5,7]
		//Output: ["0->2","4->5","7"]
		//Explanation: The ranges are:
		//[0,2] --> "0->2"
		//[4,5] --> "4->5"
		//[7,7] --> "7"
		//Example 2:
		//Input: nums = [0,2,3,4,6,8,9]
		//Output: ["0","2->4","6","8->9"]
		//Explanation: The ranges are:
		//[0,0] --> "0"
		//[2,4] --> "2->4"
		//[6,6] --> "6"
		//[8,9] --> "8->9"
		//Time complexity: O(n)
		//Space complexity: O(1)
		public static IList<string> SummaryRanges(int[] nums)
		{
			IList<string> result = new List<string>();
			if (nums.Length == 0) return result;
			int start = nums[0];
			int end = nums[0];
			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] != nums[i - 1] + 1)
				{
					end = nums[i - 1];
					if (start == end)
						result.Add($"{nums[start]}");
					else
						result.Add($"{nums[start]}->{nums[end]}");
					start = nums[i];
					end = nums[i];
				}
				
			}
			
			end = nums.Length - 1;
			if (start == end)
				result.Add($"{nums[start]}");
			else
				result.Add($"{nums[start]}->{nums[end]}");
			return result;
		}
	}
}
