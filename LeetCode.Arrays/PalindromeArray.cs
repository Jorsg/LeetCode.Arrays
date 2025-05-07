using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public static class PalindromeArray
	{
		// palindrome array
		//Given an array of integers arr, return true if the number of odd numbers in arr is the same as the number of even numbers, otherwise return false.
		public static bool palindromeArray(int[] arr)
		{
			int odd = 0, even = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0)
					even++;
				else
					odd++;
			}
			return odd == even;
		}

	}
}
