using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			for (int i = 0; i < 4; i++)
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

		public static void DuplicateZeros(int[] arr)
		{
			int zeros = 0;
			int lenght_ = arr.Length - 1;
			for (int i = 0; i <lenght_ - zeros; i++)
			{
				if (arr[i] == 0)
				{
					if (i == lenght_ - zeros)
					{
						arr[lenght_] = 0;
						lenght_++;
						break;
					}
					zeros++;
				}									
			}

			//int last = lenght_ - zeros;
			//for (int i = last; i >= 0; i++)
			//{
			//	if (arr[i] == 0)
			//	{
			//		arr[i + zeros] = 0;
			//		zeros--;
			//		arr[i + zeros] = 0;
			//	}
			//	else
			//	{
			//		arr[i + zeros] = arr[i];
			//	}
			//}
			
		}
	}
}
