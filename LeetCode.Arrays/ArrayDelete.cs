using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		//Deleting From the Start of an Array
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
					newIndex++;
				}
			}
			Console.WriteLine("Original array " + string.Join(", ", nums));
			Console.WriteLine("Array after deletion " + string.Join(", ", newArray));
		}

		//Remove Element
		public static int RemoveElement(int[] nums, int val)
		{

			return 0;
		}
	}
}
