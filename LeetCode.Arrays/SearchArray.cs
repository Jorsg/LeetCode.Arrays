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
	}
}
