using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.HashTable
{
	internal static class SetMismatch
	{
		//645. Set Mismatch
		//You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.

		//You are given an integer array nums representing the data status of this set after the error.
		//Find the number that occurs twice and the number that is missing and return them in the form of an array.

		//Example 1:	
		//Input: nums = [1, 2, 2, 4]
		//Output: [2,3]

		//Example 2:
	
		//Input: nums = [1, 1]
		//Output: [1,2]

		public static int[] FindErrorNums(int[] nums)
		{
			//Runtime:166 ms
			//Memory: 52.9 MB

			int temp;
			for (int i = 0; i < nums.Length; i++)
			{
				while (nums[i] != i + 1)
				{
					temp = nums[i];
					nums[i] = nums[temp - 1];
					nums[temp - 1] = temp;

					if (nums[i] == nums[temp - 1])
						break;
				}
			}
			for (int i = 0; i < nums.Length; i++)
			{
				if (i + 1 != nums[i])
					return new int[] { nums[i], i + 1 };
			}
			return new int[] { };

		}

		public static int[] FindErrorNumsLeetCode(int[] nums)
		{
			//Runtime:169 ms
			//Memory: 57.58 MB
			//This is a solution from LeetCode
			return [nums.Sum() - nums.Distinct().Sum(), (nums.Length * (nums.Length + 1) / 2) - nums.Distinct().Sum()];

		}


	}
}
