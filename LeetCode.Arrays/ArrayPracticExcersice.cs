using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public static class ArrayPracticExcersice
	{
		//1512. Number of Good Pairs
		//Given an array of integers nums, return the number of good pairs.
		//A pair(i, j) is called good if nums[i] == nums[j] and i<j.

		//Example 1:
		//Input: nums = [1,2,3,1,1,3]
		//Output: 4
		//Explanation: There are 4 good pairs(0,3), (0,4), (3,4), (2,5) 0-indexed.
		public static int NumIdenticalPairs(int[] nums)
		{
			int ans = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = i + 1; j < nums.Length; j++)
				{
					if (nums[i] == nums[j])// se compara uno a uno entre las dos listas,
										   // luego se acumula el resultado de la comparacion entre las listas
						ans++;

				}
			}
			return ans;
		}

		//2798. Number of Employees Who Met the Target
		//There are n employees in a company, numbered from 0 to n - 1. Each employee i has worked for hours[i] hours in the company.
		//The company requires each employee to work for at least target hours.
		//You are given a 0-indexed array of non-negative integers hours of length n and a non-negative integer target.
		//Return the integer denoting the number of employees who worked at least target hours.
		public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
		{
			//Runtime: 86 ms
			//Memory: 40.53 MB3333333
			int ans = 0;
			for (int i = 0; i < hours.Length; i++)
			{
				if (hours[i] >= target)
					ans++;
			}
			return ans;
		}


		//1431. Kids With the Greatest Number of Candies
		//There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.
		//Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.
		//Note that multiple kids can have the greatest number of candies.

		//Input: candies = [2,3,5,1,3], extraCandies = 3
		//Output: [true,true,true,false,true]
		public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
		{
			IList<bool> ans = new List<bool>();
			int maxCand = 0;

			for (int i = 0; i < candies.Length; i++)
			{
				maxCand = Math.Max(candies[i], maxCand);// Extract the highest number from the given array using the Math function in C#.
			}
			for (int i = 0; i < candies.Length; i++)
			{
				ans.Add(candies[i] + extraCandies >= maxCand);
			}
			return ans;
		}

		//1672. Richest Customer Wealth
		//You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
		//A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.

		//Example 1:
		//Input: accounts = [[1,2,3],[3,2,1]]
		//Output: 6
		//Explanation:
		//1st customer has wealth = 1 + 2 + 3 = 6
		//2nd customer has wealth = 3 + 2 + 1 = 6
		//Both customers are considered the richest with a wealth of 6 each, so return 6.
		public static int MaximumWealth(int[][] accounts)
		{

			//int cust1 = 0, cust2 = 0;
			//int[] array1 = accounts[0];
			//int[] array2 = accounts[1];
			//for (int i = 0; i < array1.Length; i++)
			//{
			//	cust1 =+ cust1 + array1[i];

			//}
			//for (int j = 0; j < array2.Length; j++)
			//{
			//	cust2 =+ cust2 + array2[j];
			//}
			//if (cust1 >= cust2)
			//	return cust1;
			//else return cust2;

			int currenMax = int.MinValue;
			for (int i = 0; i < accounts.Length; i++)
			{
				if (accounts[i].Sum() > currenMax)
				{
					currenMax = accounts[i].Sum();
				}
			}
			return currenMax;
		}

		//2824. Count Pairs Whose Sum is Less than Target
		//Given a 0-indexed integer array nums of length n and an integer target, return the number of pairs (i, j) where 0 <= i < j < n and nums[i] + nums[j] < target.

		//Input: nums = [-1,1,2,3,1], target = 2
		//Output: 3
		//Explanation: There are 3 pairs of indices that satisfy the conditions in the statement:
		//- (0, 1) since 0 < 1 and nums[0] + nums[1] = 0 < target
		//- (0, 2) since 0 < 2 and nums[0] + nums[2] = 1 < target 
		//- (0, 4) since 0 < 4 and nums[0] + nums[4] = 0 < target
		//Note that (0, 3) is not counted since nums[0] + nums[3] is not strictly less than the target.
		public static int CountPairs(IList<int> nums, int target)
		{

			//Runtime: 101
			//Memory: 41.53

			nums = nums.OrderBy(x => x).ToList();
			int left = 0, count = 0;
			int right = nums.Count - 1;
			while (left < right)
			{
				if (nums[left] + nums[right] < target)
				{
					count += right - left;
					left++;
				}
				else
					right--;
			}
			return count;
		}

		//1480. Running Sum of 1d Array
		//Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
		//Return the running sum of nums.

		//Example 1:
		//Input: nums = [1,2,3,4]
		//Output: [1,3,6,10]
		//Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
		public static int[] RunningSum(int[] nums)
		{
			//Runtime: 121 ms
			//Memory: 43.46 MB
			int sum = 0;
			int[] array = new int[nums.Length];
			for (int i = 0; i < nums.Length; i++)
			{
				sum = sum + nums[i];
				array[i] = sum;
			}
			return array;
		}

		//1365. How Many Numbers Are Smaller Than the Current Number
		//Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
		//Return the answer in an array.

		//Example 1:
		//Input: nums = [8,1,2,2,3]
		//Output: [4,0,1,1,3]
		//Explanation: 

		//For nums[0]=8 there exist four smaller numbers than it (1, 2, 2 and 3). 
		//For nums[1]=1 does not exist any smaller number than it.
		//For nums[2]=2 there exist one smaller number than it (1). 
		//For nums[3]=2 there exist one smaller number than it (1). 
		//For nums[4]=3 there exist three smaller numbers than it (1, 2 and 2).
		public static int[] SmallerNumbersThanCurrent(int[] nums)
		{

			//Runtime: 131 ms
			//Memory: 44.46 MB
			int[] result = new int[nums.Length];
			int count = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				for (int j = 0; j < nums.Length; j++)
				{
					if (nums[j] < nums[i])
						count++;

				}
				result[i] = count;
				count = 0;
			}
			return result;
		}

		//2114. Maximum Number of Words Found in Sentences
		public static int MostWordsFound(string[] sentences)
		{
			//Runtime: 72 ms
			//Memory: 41.78 MB

			int count = 0;

			for (int i = 0; i < sentences.Length; i++)
			{
				string[] words = sentences[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				int countWords = words.Length;
				if (countWords > count)
				{
					count = countWords;
				}
			}

			return count;
		}

		//1909. Remove One Element to Make the Array Strictly Increasing
		//Given a 0-indexed integer array nums, return true if it can be made strictly increasing after removing exactly one element, or false
		//otherwise. If the array is already strictly increasing, return true.
		//The array nums is strictly increasing if nums[i - 1] < nums[i] for each index (1 <= i < nums.length).

		//Example 1:
		//Input: nums = [1,2,10,5,7]
		//Output: true
		//Explanation: By removing 10 at index 2 from nums, it becomes [1,2,5,7].
		//[1,2,5,7] is strictly increasing, so return true.
		public static bool CanBeIncreasing(int[] nums)
		{
			//Runtime: 89 ms
			//Memory: 41.00 MB
			int count = 0;
			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i - 1] >= nums[i])
				{
					count++;
					if (count > 1)
						return false;
				}
				if (i > 1 && nums[i - 2] >= nums[i])
					nums[i] = nums[i - 1];
			}
			return true;
		}

		//35. Search Insert Position
		public static int SearchInsert(int[] nums, int target)
		{
			//Runtime: 82 ms
			//Memory: 39.44 MB
			int index = 0;
			Array.Sort(nums);
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == target)
				{
					index = i;
					break;
				}
				else if (nums[i] < target)
				{
					index = i + 1;
				}
			}
			return index;
		}


		//33. Search in Rotated Sorted Array
		//There is an integer array nums sorted in ascending order (with distinct values).
		//Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting
		//array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might
		//be rotated at pivot index 3 and become [4,5,6,7,0,1,2].
		//Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
		//You must write an algorithm with O(log n) runtime complexity.
		//Example 1:
		//Input: nums = [4,5,6,7,0,1,2], target = 0
		//Output: 4
		public static int Search(int[] nums, int target)
		{
			//Runtime: 72 ms
			//Memory: 39.36 MB
			int left = 0;
			int right = nums.Length -1;

			while (left<=right)
			{
				int mid = left + (right - left) / 2;
				if (nums[mid] == target) return mid;

				if (nums[left] <= nums[mid])
				{
					if (nums[left] <= target && target < nums[mid])
					{
						right = mid - 1;
					}else
						left = mid + 1;
				}
				else
				{
					if (nums[mid] < target && target <= nums[right])
						left = mid + 1;
					else
						right = mid - 1;
				}
			}
			return -1;
		}


		//1720. Decode XORed Array
		//There is a hidden integer array arr that consists of n non-negative integers.
		//It was encoded into another integer array encoded of length n - 1, such that encoded[i] = arr[i] XOR arr[i + 1]. For example, if arr = [1,0,2,1], then encoded = [1,2,3].
		//You are given the encoded array. You are also given an integer first, that is the first element of arr, i.e. arr[0].
		//Return the original array arr. It can be proved that the answer exists and is unique.

		//Example 1:
		//Input: encoded = [1,2,3], first = 1
		//Output: [1,0,2,1]
		//Explanation: If arr = [1,0,2,1], then first = 1 and encoded = [1 XOR 0, 0 XOR 2, 2 XOR 1] = [1,2,3]
		public static int[] Decode(int[] encoded, int first)
		{
			//Runtime: 158 md
			//Memory: 60.22 MB
			int[] decode = new int[encoded.Length + 1];
			decode[0] = first;
			for (int i = 0; i < encoded.Length; i++)
			{
				decode[i + 1] = encoded[i] ^ decode[i];
			}
			return decode;
		}


		//2574. Left and Right Sum Differences
		//Given a 0-indexed integer array nums, find a 0-indexed integer array answer where:
		//answer.length == nums.length.
		//answer[i] = |leftSum[i] - rightSum[i]|.
		//leftSum[i] is the sum of elements to the left of the index i in the array nums. If there is no such element, leftSum[i] = 0.
		//rightSum[i] is the sum of elements to the right of the index i in the array nums. If there is no such element, rightSum[i] = 0.

		//Example 1:
		//Input: nums = [10,4,8,3]
		//Output: [15,1,11,22]
		//Explanation: The array leftSum is [0,10,14,22] and the array rightSum is [15,11,3,0].
		//The array answer is [|0 - 15|,|10 - 11|,|14 - 3|,|22 - 0|] = [15,1,11,22].
		public static int[] LeftRightDifference(int[] nums)
		{
			//Runtime: 143 md
			//Memory: 43.22 MB
			int[] leftSum = new int[nums.Length];
			int[] rightSum = new int[nums.Length];

			for (int i = 0; i < nums.Length - 1; i++)
			{
				leftSum[i + 1] = leftSum[i] + nums[i];
				rightSum[nums.Length - (i + 2)] = rightSum[nums.Length - (i + 1)] + nums[nums.Length - (i + 1)];
			}
			for (int i = 0; i < nums.Length; i++)
			{
				nums[i] = Math.Abs(leftSum[i] - rightSum[i]);
			}
			return nums;
		}

	}

}
