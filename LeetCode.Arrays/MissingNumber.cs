using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	internal static class MissingNumber
	{
		//LeetCode 268 Missing Number
		//Given an array nums containing n disting numbers in the range [0,n], return the only number in the range that is missing from the array.

		//Example 1:
		//Input: nums = [3,0,1]
		//Output: 2

		//Example 2:
		//Input: nums = [0,1]
		//Output: 2

		//Example 3:
		//Input: nums = [9,6,4,2,3,5,7,0,1]
		//Output: 8

		public static int MissingNumberSolution(int[] nums)
		{
			//ordernar el array de mayor a menor
			Array.Sort(nums);
			int _index1 = 0, _index2 = 0, number = 0;
			//recorrer el array con un for
			for (int i = 0; i < nums.Length; i++)
			{
				_index1 = nums[i];
				_index2 = nums[i + 1];
				number = _index2 - _index1;
				if (number > 1)
				{
					return _index1 + 1;
				}
			}

			return _index1 + 1;
		}
	}
}
