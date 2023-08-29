using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.Arrays
{
	public static class ArrayInsertions
	{
		//Inserting at the End of an Arry

		public static void InserEndArray()
		{
			//Declare an integer array of 6
			int[] intArray = new int[6];
			int length = 0;

			//Add 3 element to the Array
			for (int i = 0; i < 3; i++)
			{
				intArray[length] = i;
				length++;
			}
			for (int i = 0; i < intArray.Length; i++)
			{
				Console.WriteLine("Index " + i + " contains" + intArray[i]);
			}
		}

		//Inserting at the Start of an Array

		public static void InsertSrtarArray()
		{
			//Declare an integer array of 6
			int[] intArray = new int[6];
			int length = 0;

			//Add 3 element to the Array
			for (int i = 4; i >= 0; i--)
			{
				intArray[i] = intArray[i + 1];
			}
			intArray[0] = 20;
			for (int i = 0; i < intArray.Length; i++)
			{
				Console.WriteLine("Index " + i + " contains" + intArray[i]);
			}
		}

		//Duplicate Zeros
		//Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
		//Note that elements beyond the length of the original array are not written.Do the above modifications to the input array in place and do not return anything.

		public static void DuplicateZeros(int[] arr)
		{
			int zeros = 0;
			for (int i = 0; i < arr.Length; i++)

				if (arr[i] == 0)// acumulo los zeros
					zeros++;

			int len = arr.Length - 1; // asigno la cantidad de elementos en el array y le quito una posicion
			while (len > 0 && zeros > 0)
			{
				if (len + zeros <= arr.Length - 1)
					arr[len + zeros] = arr[len];// agrego el nuevo elemento y el zero

				if (arr[len] == 0)
					zeros--;

				arr[len] = 0;
				len--;

			}
		}

		//Merge Sorted Array
		//You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
		//Merge nums1 and nums2 into a single array sorted in non-decreasing order.
		//The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
		public static void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			
			//Solution leetCode
			for (int i = 0; i < nums2.Length; i++)
			{
				nums1[nums1.Length - 1 - i] = nums2[i];		//asigna el valor del array2 para crear el nuevo array con los
															//nuevos elementos en array1	
			}
			Array.Sort(nums1);// Ordena de menor a mayor
			
			foreach (int item in nums1) Console.WriteLine(item);// imprime

		}
	}
}
