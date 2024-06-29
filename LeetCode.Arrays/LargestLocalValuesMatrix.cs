using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public static class LargestLocalValuesMatrix
	{
		public static int[][] LargestLocal(int[][] grid)
		{
			int n = grid.Length;
			int[][] maxLocal = new int[n-2][];

            for (int i = 0; i < n -2; i++)
            {
				maxLocal[i] = new int[n - 2];
                for (int j = 0; j < n -2; j++)
                {
                    maxLocal[i][j] = FindMaxInSubMatrix(grid, i, j);
				}
            }
			return maxLocal;
		}
			
		

		private static int FindMaxInSubMatrix(int[][] grid, int i, int j)
		{
			int max = int.MinValue;
			for (int x = i; x < i + 3; x++)
			{
				for (int y = j; y < j + 3; y++)
				{
					max = Math.Max(max, grid[x][y]);
				}
			}
			return max;
		}
	}
}
