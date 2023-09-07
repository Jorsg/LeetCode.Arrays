using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public static class SearchArray
	{
		public static bool LinearSearch(int[] array, int lenght, int element)
		{
			if (array == null || lenght == 0)
				return false;


			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == element)
					return true;
			}

			return false;
		}


		//Check If N and Its Double Exist
		public static bool CheckIfExist(int[] arr)
		{

			if (arr == null || arr.Length == 0)
				return false;

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr.Length; j++)
				{
					if (arr[i] == (arr[j] * 2) && i != j)
						return true;
				}
			}
			return false;
		}

		// valid Mountain Array
		//Given an array of integers arr, return true if and only if it is a valid mountain array.
		public static bool validMountainArray(int[] arr)
		{
			int len = arr.Length, left = 0, right = len - 1;

			while (left + 1 < len && arr[left] < arr[left + 1]) left++;
			while (right - 1 > -1 && arr[right - 1] > arr[right]) right--;
			return (left == right && left != 0 && right != len - 1);
		}
	}
}
