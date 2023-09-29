using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class SpiralOrder
	{
		//54. Spiral Matrix
		//Given an m x n matrix, return all elements of the matrix in spiral order.

		//Example 1:
		//Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
		//Output: [1,2,3,6,9,8,7,4,5]
		public IList<int> FindSpiralOrder(int[][] matrix)
		{

			//Runtime: 125 ms
			//Memory: 42.74 MB
			int len = matrix.Length;
			var list = new List<int>();
			int top =0, bottom = len-1, left =0, right = matrix[0].Length -1;
			while (true)
			{
				for (int i = left; i <= right; i++)
				{
					list.Add(matrix[top][i]);
				}
				top++;
				if (top > bottom || left > right) break;

				for (int i = top; i <= bottom; i++)
					list.Add(matrix[i][right]);
				right--;

				if (top > bottom || left > right) break;

				for(int i = right; i >= left; i--)
					list.Add(matrix[bottom][i]);
				bottom--;

				if (top > bottom || left > right) break;

				for(int i = bottom; i>= top; i--)
					list.Add(matrix[i][left]);
				left++;

				if (top > bottom || left > right) break;
			}


			return list;
		}
	}
}
