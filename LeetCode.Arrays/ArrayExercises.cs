using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Arrays
{
	public static class ArrayExercises
	{

		//Height Checker
		//A school is trying to take an annual photo of all the students. The students are asked to stand in a single file line in non-decreasing order by
		//height. Let this ordering be represented by the integer array expected where expected[i] is the expected height of the ith student in line
		//You are given an integer array heights representing the current order that the students are standing in. Each heights[i] is the height of the ith student in line (0-indexed).
		//Return the number of indices where heights[i] != expected[i].
		public static int HeightChecker(int[] heights)
		{
			//Runtime: 80 ms
			//Memory Usage: 38.8 MB

			int[] expected = new int[heights.Length];
			int height = 0;
			expected = heights.OrderBy(x => x).ToArray();
			for (int i = 0; i < heights.Length; i++)
			{
				if (heights[i] != expected[i])
					height++;
			}
			return height;

			//Runtime: 64 ms

			//int[] expected = (int[])heights.Clone();
			//Array.Sort(expected);
			//int k = 0;

			//for (int i = 0; i < heights.Length; i++)
			//{
			//	if (heights[i] != expected[i])
			//		k++;
			//}
			//return k;
		}

		//Max Consecutive Ones II
		//Given a binary array nums, return the maximum number of consecutive 1's in the array if you can flip at most one 0.
		public static int FindMaxConsecutiveOnes(int[] nums)
		{
			//Runtime: 101  ms
			//Memory Usage: 52.4 MB

			int longSequence = 0;
			int left = 0, right = 0;
			int numZeros = 0;

			while (right < nums.Length)
			{
				if (nums[right] == 0)
					numZeros++;

				while (numZeros == 2)
				{
					if (nums[left] == 0)
					{
						numZeros--;
					}
					left++;
				}

				longSequence = Math.Max(longSequence, right - left + 1);
				right++;
			}

			return longSequence;
		}

		//Third Maximum Number
		//Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.
		public static int ThirdMax(int[] nums)
		{

			//Runtime: 90 ms
			//Memory Usage: 39.5 MB
			//answer LeetCode
			long first = long.MinValue, second = long.MinValue, third = long.MinValue;

			foreach (var num in nums)
			{
				if (num == first || num == second || num == third)
					continue;

				if (num > first)
				{
					third = second;
					second = first;
					first = num;
				}
				else if (num > second)
				{
					third = second;
					second = num;
				}
				else if (num > third)
				{
					third = num;
				}
			}

			return (int)(third == long.MinValue ? first : third);
		}

		//Find All Numbers Disappeared in an Array
		//Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
		public static IList<int> FindDisappearedNumbers(int[] nums)
		{
			//Runtime:  1715  ms no es eficiente la soluacion
			//Memory Usage: 55.3 MB
			IList<int> result = new List<int>();
			int num = 1;
			Array.Sort(nums);
			for (int i = 0; i < nums.Length; i++)
			{
				if (!nums.Contains(num))
					result.Add(num);

				num++;
			}

			return result;

			// Runtime: 205 ms
			//Memory Usage: 53.5 MB
			//return Enumerable.Range(1, nums.Length).ToHashSet().Except(nums).ToList();



			// Runtime: 162 ms muy eficiente la solucion
			// Otra forma de resolver el problema usando un metodo swap
			//	int n = nums.Length;
			//	for (int i = 0; i < n; i++)
			//	{
			//		int expecting = i + 1;
			//		while (nums[i] != expecting)
			//		{
			//			int j = nums[i] - 1;
			//			if (nums[j] == nums[i]) break;
			//			swap(nums, i, j);
			//		}
			//	}

			//	List<int> missing = new List<int>();
			//	for (int i = 0; i < n; i++)
			//	{
			//		int expecting = i + 1;
			//		int actual = nums[i];
			//		if (actual != expecting) missing.Add(expecting);
			//	}
			//	return missing;
			//}

			//private void swap(int[] nums, int i, int j)
			//{
			//	int temp = nums[i];
			//	nums[i] = nums[j];
			//	nums[j] = temp;
			//}
		}

		//Given a zero-based permutation nums (0-indexed), build an array ans of the same length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it.
		//A zero-based permutation nums is an array of distinct integers from 0 to nums.length - 1 (inclusive).
		//Example 1:
		//Input: nums = [0,2,1,5,3,4]
		//Output: [0,1,2,4,5,3]
		//Explanation: The array ans is built as follows:
		//ans = [nums[nums[0]], nums[nums[1]], nums[nums[2]], nums[nums[3]], nums[nums[4]], nums[nums[5]]]
		// = [nums[0], nums[2], nums[1], nums[5], nums[3], nums[4]]
		// = [0,1,2,4,5,3]
		public static int[] BuildArray(int[] nums)
		{

			//Runtime: 130ms Beats 93.13%of users with C#
			//Memory: 50.22MB Beats 17.46 % of users with C#
			int[] result = new int[nums.Length];

			for (int i = 0; i < nums.Length; i++)
			{
				result[i] = nums[nums[i]];
			}
			return result;
		}


		//Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
		//Specifically, ans is the concatenation of two nums arrays. Return the array ans.
		//Example 1:
		// Input: nums = [1,2,1]
		//Output: [1,2,1,1,2,1]
		//Explanation: The array ans is formed as follows:
		//- ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
		//- ans = [1,2,1,1,2,1]
		public static int[] GetConcatenation(int[] nums)
		{
			//Runtime : 136 ms Beats 65.05 % of users with C#
			//Memory: 47.72MB Beats 95.33 % of users with C#

			int n = nums.Length * 2;
			int[] result = new int[n];
			for (int i = 0; i < nums.Length; i++)
			{
				result[i] = nums[i];
				result[i + nums.Length] = nums[i];
			}
			return result;
		}

		//Final Value of Variable After Performing Operations
		//There is a programming language with only four operations and one variable X:
		//++X and X++ increments the value of the variable X by 1.
		//--X and X-- decrements the value of the variable X by 1.
		//Initially, the value of X is 0.
		//Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations.

		public static int FinalValueAfterOperations(string[] operations)
		{
			//Runtime : 63 ms
			//Memory : 40.28MB
			int x = 0;
			for (int i = 0; i < operations.Length; i++)
			{
				if (operations[i] == "--X" || operations[i] == "X--")
				{
					x--;

				}
				else if (operations[i] == "++X" || operations[i] == "X++")
				{
					x++;
				}
			}
			return x;
		}

		//1470. Shuffle the Array
		//Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
		//Return the array in the form[x1, y1, x2, y2, ..., xn, yn].

		//Example 1:

		//Input: nums = [2,5,1,3,4,7], n = 3
		//Output: [2,3,5,4,1,7]
		//Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].

		//Example 2:

		//Input: nums = [1,2,3,4,4,3,2,1], n = 4
		//Output: [1,4,2,3,3,2,4,1]

		//Example 3:

		//Input: nums = [1,1,2,2], n = 2
		//Output: [1,2,1,2]

		public static int[] Shuffle(int[] nums, int n)
		{
			//Runtime: 136
			// Memory: 45.02MB
			int[] result = new int[n * 2];
			for (int i = 0; i < n; i++)
			{
				result[2 * i] = nums[i];
				result[(2 * i) + 1] = nums[i + n];
			}

			return result;
		}


		public static int[] RunningSum(int[] nums)
		{
			int[] array = new int[nums.Length];
			int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
				sum += nums[i];
				array[i] = sum;
            }

            return array;
		}
	}
}
