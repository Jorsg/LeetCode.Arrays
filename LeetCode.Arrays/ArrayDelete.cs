using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.Arrays
{
	public static class ArrayDelete
	{
		//Deleting From the End of an Array

		public static void DeletingEndArray()
		{
			//Declare an integer array of 6
			int[] intArray = new int[10];
			int length = 0;

			//Add 3 element to the Array
			for (int i = 0; i < 6; i++)
			{
				intArray[length] = i;
				length++;
			}
			
			for (int i = 0; i < intArray.Length; i++)
			{
				Console.WriteLine("Index " + i + " contains" + intArray[i]);
			}
		}

		//Deleting From the Start of an Array
		public static void DeletinSrtarArray()
		{
			int[] nums = { 10, 20, 30, 40, 50 };
			int indexToDelete = 0;
			int newArrayLength = nums.Length - 1;

			int[] newArray = new int[newArrayLength];
			for (int i = 0;i < newArrayLength;i++)
			{
				newArray[i] = nums[i + 1];// Shift elements to the left // desplazar elemeento a la izquierda
			}
			Console.WriteLine("Original array " + string.Join(", ", nums));
			Console.WriteLine("Array after deletion " + string.Join(", ", newArray));
		}

		//Deleting From the Anywhere in the Array
		public static void DeletinAnyWhereArray()
		{
			int[] nums = { 10, 20, 30, 40, 50 };
			int indexToDelete = 2; // Indice del elemento a eliminar
			int newArrayLength = nums.Length - 1;

			int[] newArray = new int[newArrayLength];
			int newIndex = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (i != indexToDelete)// si la posicion i es diferente del indice a eliminar, se llena el nuevo array
				{
					newArray[newIndex] = nums[i];
					newIndex++; //incrementa los indeces del array
				}
			}
			Console.WriteLine("Original array " + string.Join(", ", nums));
			Console.WriteLine("Array after deletion " + string.Join(", ", newArray));
		}

		//Remove Element
		//Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the elements may be changed.Then return the number of elements in nums which are not equal to val.
		public static int RemoveElement(int[] nums, int val)
		{

			//Runtime: 120 ms
			//Memory Usage: 42.9MB

			int[] newArray = new int[nums.Length];
			int newIndex = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != val)
				{
					newArray[newIndex] = nums[i];
					newIndex++;
				}
			}
			return (newIndex);

		}

		//Remove Duplicates from Sorted Array
		//Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once.
		//The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
		public static int RemoveDuplicates(int[] nums)
		{
			int noDuplicate = 0;

			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[noDuplicate] != nums[i])
				{
					nums[noDuplicate + 1] = nums[i];
					noDuplicate++;
				}
			}
			return ++noDuplicate;
		}



		//80. Remove Duplicates from Sorted Array II
		public static int RemoveDuplicatesII(int[] nums)
		{
			if (nums.Length <= 2) return nums.Length;
			

			int noDuplica = 2;
			for (int i = 2; i < nums.Length; i++)
			{
				if (nums[i] != nums[noDuplica -2])
				{
					nums[noDuplica++] = nums[i];
				}
			}

			return noDuplica;
		}
	}
}
