using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public class DegreeArray697LeetCode
	{
		//697. Degree of an Array
		//Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.
		//Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.

		//Example 1:
		//Input: nums = [1,2,2,3,1]
		//Output: 2
		//Explanation: The input array has a degree of 2 because both elements 1 and 2 appear twice.
		//Of the subarrays that have the same degree:
		//[1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 3, 1]
		//The shortest length is 2. So return 2.

		//Example 2:
		//Input: nums = [1,2,2,3,1,4,2]
		//Output: 6
		//Explanation: The degree is 3 because the element 2 is repeated 3 times.
		//So [2,2,3,1,4,2] is the shortest subarray, therefore the answer is 6.

		public static int FindShortestSubArray(int[] nums)
		{
			Dictionary<int, int> left = new();
			Dictionary<int, int> right = new();
			Dictionary<int, int> count = new();
			int degree = 0;
			foreach (int i in nums)
			{
				if (!left.ContainsKey(i))
					left[i] = Array.IndexOf(nums, i);
				right[i] = Array.LastIndexOf(nums, i);
				count[i] = count.GetValueOrDefault(i, 0) + 1;
				degree = Math.Max(degree, count[i]);
			}
			int res = nums.Length;
			foreach (int i in count.Keys)
			{
				if (count[i] == degree)
					res = Math.Min(res, right[i] - left[i] + 1);
			}
			return res;
		}
	}
}
