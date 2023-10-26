using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class Pascal_sTriangle
	{
		//118. Pascal's Triangle
		//Given an integer numRows, return the first numRows of Pascal's triangle.
		//In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
		//Example 1:
		//Input: numRows = 5
		//Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
		public IList<IList<int>> Generate(int numRows)
		{
			//Runtime: 93 ms
			//Memory Usage: 38.98 MB

			var triangle = new List<IList<int>>();

			if (numRows == 0) return triangle;

			triangle.Add(new List<int>(1) { 1 });
			if (numRows == 1) return triangle;
			triangle.Add(new List<int>(2) { 1, 1 });
			if (numRows == 2) return triangle;

			for (int i = 2; i < numRows; i++)
			{
				IList<int> result = new List<int>();
				result.Add(1);
				for (int j = 1; j < i; j++)
				{
					var number = triangle[i - 1][j - 1] + triangle[i - 1][j];
					result.Add(number);
				}
				result.Add(1);
				triangle.Add(result);
			}

			return triangle;
		}

		//119. Pascal's Triangle II
		//Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.
		//In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:


		//Example 1:
		//Input: rowIndex = 3
		//Output: [1,3,3,1]
		public IList<int> GetRow(int rowIndex)
		{
			//Runtime: 88 ms
			//Memory Usage: 36.3 MB
			List<List<int>> triangle = new List<List<int>>();
			for (int i = 0; i <= rowIndex; i++)
			{
				List<int> row = new List<int>();
				for (int j = 0; j <= i; j++)
				{
					if (j == 0 || j == i)
						row.Add(1);
					else
					{
						int prevRow = j - 1;
						int leftVal = triangle[prevRow][j - 1];
						int rightVal = triangle[prevRow][j];
						row.Add(leftVal + rightVal);
					}
				}
				triangle.Add(row);
			}
			return triangle[rowIndex];
		}


	}
}
