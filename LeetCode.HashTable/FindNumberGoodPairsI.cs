using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public class FindNumberGoodPairsI
	{
		//3162. Find the Number of Good Pairs I
		//Given two arrays of integers nums1 and nums2, return the number of pairs (i, j) such that i < j and nums1[i] * k == nums2[j].
		//A pair(i, j) is called good if there are no other good pairs(i1, j1) where i1 < j1 and nums1[i1] * k == nums2[j1].
		//Example 1:
		//Input: nums1 = [1, 2, 2, 4], nums2 = [2, 2], k = 2
		//Output: 2
		//Explanation: There are two good pairs(0, 1) and(0, 2).
		public static int NumberOfPairs(int[] nums1, int[] nums2, int k)
		{
			int n1 = nums1.Length;
			int n2 = nums2.Length;
			int result = 0;
			for (int j = 0; j < n2; j++)
			{
				nums2[j] *= k;
			}

			for (int i = 0; i < n1; i++)
			{
				for (int j = 0; j < n2; j++)
				{
					if (nums1[i] % nums2[j] == 0)
					{
						result++;
					}
				}
			}

			return result;

		}
	}
}
