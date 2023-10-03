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
	}
}
