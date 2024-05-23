using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class NumeroConsecutivo
	{
		public static int NumeroGuay(int num)
		{
			int sum = 0;

			for (int i = 0; i < num; i++)
			{
				if (sum == num)
					break;
				else
					sum += i;
			}
			if (sum == num)
				return sum;
			else
				return -1;
		}


		//crear el linear search
		public static int LinearSearch(int[] arr, int target)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == target)
					return i;
			}
			return -1;
		}
		//Simple search
		public static int SimpleSearch(int[] arr, int target)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == target)
					return i;
			}
			return -1;
		}
		

		////quicksort
		//public static void QuickSort(int[] arr, int left, int right)
		//{
		//	if (left < right)
		//	{
		//		int pivot = Partition(arr, left, right);
		//		if (pivot > 1)
		//		{
		//			QuickSort(arr, left, pivot - 1);
		//		}
		//		if (pivot + 1 < right)
		//		{
		//			QuickSort(arr, pivot + 1, right);
		//		}
		//	}
		//}

		//selection sort
		public static void SelectionSort(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int min = i;
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (arr[j] < arr[min])
						min = j;
				}
				int temp = arr[min];
				arr[min] = arr[i];
				arr[i] = temp;
			}
		}

		//Travelling Salesperson
		public static int TravellingSalesperson(int[,] arr)
		{
			int min = int.MaxValue;
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					if (arr[i, j] < min)
						min = arr[i, j];
				}
			}
			return min;
		}

		//Binary search
		public static int BinarySearch(int[] arr, int target)
		{
			int left = 0;
			int right = arr.Length - 1;
			while (left <= right)
			{
				int mid = left + (right - left) / 2;
				if (arr[mid] == target)
					return mid;
				if (arr[mid] < target)
					left = mid + 1;
				else
					right = mid - 1;
			}
			return -1;
		}
	}

}
