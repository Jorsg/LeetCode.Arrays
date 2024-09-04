using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class SetZeroMatrix
	{
		//1.8 Zero Matrix
		//Write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0.
		public static bool ZeroMatrix(int[,] matriz)
		{
			bool[] row = new bool[matriz.GetLength(0)];
			bool[] column = new bool[matriz.GetLength(1)];
			bool result = false;
			for (int i = 0; i < matriz.GetLength(0); i++)
			{
				for (int j = 0; j < matriz.GetLength(1); j++)
				{
					if (matriz[i, j] == 0)
					{
						row[i] = true;
						column[j] = true;
						result = true;
					}
				}
			}
			return result;

		}
	}
}
