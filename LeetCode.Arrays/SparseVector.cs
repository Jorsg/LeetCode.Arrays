using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public class SparseVector
	{
		//1570. Dot Product of Two Sparse Vectors
		//Given two sparse vectors, compute their dot product.
		//Implement class SparseVector:
		//SparseVector(nums) Initializes the object with the vector nums
		//dotProduct(vec) Compute the dot product between the instance of SparseVector and vec
		//A sparse vector is a vector that has mostly zero values, you should store the sparse vector efficiently and compute the dot product between two SparseVector.
		//Follow up: What if only one of the vectors is sparse?

		//Example 1:
		//Input: nums1 = [1,0,0,2,3], nums2 = [0,3,0,4,0]
		//Output: 8
		//Explanation: v1 = SparseVector(nums1) , v2 = SparseVector(nums2)
		//v1.dotProduct(v2) = 1*0 + 0*3 + 0*0 + 2*4 + 3*0 = 8
		//
		private int[] array;
		public SparseVector(int[] nums)
		{
			array = nums;
		}

		// Return the dotProduct of two sparse vectors
		public int DotProduct(SparseVector vec)
		{
			//Runtime: 308 ms
			//Memory: 63.71 MB
			int result = 0;
			for (int i = 0; i < array.Length; i++)
			{
				result += array[i] * vec.array[i];
			}
			return result;
		}
	}
}
