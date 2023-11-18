using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public static class ArrayExercise3
	{
		//1389. Create Target Array in the Given Order
		//Given two arrays of integers nums and index. Your task is to create target array under the following rules:
		//Initially target array is empty.
		//From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
		//Repeat the previous step until there are no elements to read in nums and index.
		//Return the target array.
		//It is guaranteed that the insertion operations will be valid.

		//Example 1:
		//Input: nums = [0,1,2,3,4], index = [0,1,2,2,1]
		//Output: [0,4,1,3,2]
		//Explanation:
		//nums index     target
		//0            0        [0]
		//1            1        [0,1]
		//2            2        [0,1,2]
		//3            2        [0,1,3,2]
		//4            1        [0,4,1,3,2]
		public static int[] CreateTargetArray(int[] nums, int[] index)
		{
			//Runtime: 128 ms
			//Memory: 42.52 MB
			List<int> target = new List<int>();
			for (int i = 0; i < nums.Length; i++)
			{
				target.Insert(index[i], nums[i]);
			}
			return target.ToArray();
		}


		//1313. Decompress Run-Length Encoded List
		//We are given a list nums of integers representing a list compressed with run-length encoding.
		//Consider each adjacent pair of elements[freq, val] = [nums[2 * i], nums[2 * i + 1]](with i >= 0).For each such pair, there are freq elements with value val concatenated in a sublist.Concatenate all the sublists from left to right to generate the decompressed list.
		//Return the decompressed list.

		//Example 1:
		//
		//Input: nums = [1,2,3,4]
		//		Output: [2,4,4,4]
		//		Explanation: The first pair[1, 2] means we have freq = 1 and val = 2 so we generate the array[2].
		//The second pair[3, 4] means we have freq = 3 and val = 4 so we generate[4, 4, 4].
		//At the end the concatenation[2] + [4,4,4] is [2,4,4,4].
		public static int[] DecompressRLElist(int[] nums)
		{
			//Runtime: 129 ms
			//Memory: 47.93 MB
			IList<int> result = new List<int>();
			for (int i = 0; i < nums.Length; i += 2)
			{
				int feq = nums[i];
				int val = nums[i + 1];
				for (int j = 1; j <= feq; j++)
				{
					result.Add(val);
				}
			}
			return result.ToArray();
		}
	}
}
