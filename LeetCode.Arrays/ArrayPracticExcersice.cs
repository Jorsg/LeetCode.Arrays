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
			int right = nums.Count  -1;
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
	}
}
