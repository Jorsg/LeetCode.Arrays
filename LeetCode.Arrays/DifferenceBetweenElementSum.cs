using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace LeetCode.Arrays
{
	internal static class DifferenceBetweenElementSum
	{
		//2535. Difference Between Element Sum and Digit Sum of an Array
		//You are given a positive integer array nums.
		
		//The element sum is the sum of all the elements in nums.
		//The digit sum is the sum of all the digits(not necessarily distinct) that appear in nums.
		//Return the absolute difference between the element sum and digit sum of nums.
		//
		//Note that the absolute difference between two integers x and y is defined as |x - y|.
		
		//Example 1:
		
		//Input: nums = [1,15,6,3]
		//Output: 9
		//Explanation: 
		//The element sum of nums is 1 + 15 + 6 + 3 = 25.
		//The digit sum of nums is 1 + 1 + 5 + 6 + 3 = 16.
		//The absolute difference between the element sum and digit sum is |25 - 16| = 9.

		public static int DifferenceOfSum(int[] nums)
		{
			//Runtime: 97 ms
			//Memory: 45.5 MB
			int sum = 0; int result = 0; int sumDig = 0, reminder;
			for (int i = 0; i < nums.Length; i++)
			{
				sum += nums[i];
			}


			string numer = string.Join("", nums.Select(p => p.ToString()).ToArray());

			sumDig = numer.ToString().Sum(c => c - '0');

			result = Math.Abs(sum - sumDig);

			return result;
		}
	}
}
