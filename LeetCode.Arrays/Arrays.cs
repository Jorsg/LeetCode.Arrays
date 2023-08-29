using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public static class Arrays
	{

		//Given a binary array nums, return the maximum number of consecutive 1's in the array.
		public static int FindMaxConsecutiveOnes(int[] nums)
		{
			int maxCount = 0;
			int count = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == 1)
					count++;
				else
				{
					maxCount = Math.Max(maxCount, count);
					count = 0;
				}
			}
			return Math.Max(maxCount, count);
		}

		//Find Numbers with Even Number of Digits
		//Given an array nums of integers, return how many of them contain an even number of digits.
		public static int FindNumbers(int[] nums)
		{
			int count = 0;
			for (int i = 0; i < nums.Length; i++)
			{

				if ((nums[i].ToString().Length % 2) == 0)
					count++;
			}
			return count;
		}

		//Squares of a Sorted Array
		//Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
		public static int[] SortedSquares(int[] nums)
		{
			int[] matrix = new int[nums.Length];

			for (int i = 0; i < nums.Length; i++)
			{
				matrix[i] = nums[i] * nums[i];
			}
			for (int m = 1; m < matrix.Length; m++)
			{
				for (int n = 0; n < matrix.Length - m; n++)
				{
					if (matrix[n] > matrix[n + 1])
					{
						int temp = matrix[n];
						matrix[n] = matrix[n + 1];
						matrix[n + 1] = temp;
					}
				}
			}

			return matrix;
		}

	}
}
