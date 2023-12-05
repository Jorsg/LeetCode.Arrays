using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public static class IntersectionTwoArrays
	{
		
        public static int[] Intersection(int[] nums1, int[] nums2)
		{
			var setOne = new HashSet<int>(nums1);
			var setTwo = new HashSet<int>(nums2);
			var result = new List<int>();

			foreach (var item in setOne)
			{
				if (setTwo.Contains(item))
					result.Add(item);
			}

			return result.ToArray();
		}


		//350. Intersection of Two Arrays II
		//Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
				
		//Example 1:		
		//Input: nums1 = [1,2,2,1], nums2 = [2,2]
		//Output: [2,2]

		//Example 2:		
		//Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
		//Output: [4,9]
		//Explanation: [9,4] is also accepted.
		public static int[] Intersect(int[] nums1, int[] nums2)
		{
			//Runtime: 138 ms
			//Memory Usage: 43.6 MB
						var result = new List<int>();
			int[] nums = new int[1001];

			for (int i = 0; i < nums1.Length; i++)
			{
				nums[nums1[i]]++;
			}
			for (int i = 0; i < nums2.Length; i++)
			{
				if (nums[nums2[i]] > 0)
				{
					result.Add(nums2[i]);
					nums[nums2[i]]--;
				}
			}
			
			return result.ToArray();
		}

		
	}
}
