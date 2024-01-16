using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	internal static class ValidSudoku
	{
		//36. Valid Sudoku
		//Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

		//Each row must contain the digits 1-9 without repetition.
		//Each column must contain the digits 1-9 without repetition.
		//Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.

		//Note:
		//A Sudoku board (partially filled) could be valid but is not necessarily solvable.
		//Only the filled cells need to be validated according to the mentioned rules.

		public static bool IsValidSudoku(char[][] board)
		{
			//Runtime: 98 ms
			//Memory: 48.34 MB

			HashSet<char>[] rows = new HashSet<char>[9];
			HashSet<char>[] cols = new HashSet<char>[9];
			HashSet<char>[] boxes = new HashSet<char>[9]; // 3x3 squere is a box


			//initialize each hashSet for each array (rows, cols, boxes)
			for (int i = 0; i < 9; i++)
			{
				rows[i] = new HashSet<char>();
				cols[i] = new HashSet<char>();
				boxes[i] = new HashSet<char>();
			}

			char val = 'a';
			int boxNo = -1;
			for (int r = 0; r < 9; r++)
			{
				for (int c = 0; c < 9; c++)
				{
					val = board[r][c];
					if (val == '.') // box has no values
						continue;

					if (rows[r].Contains(val))
						return false;
					rows[r].Add(val);

					if (cols[c].Contains(val))
						return false;
					cols[c].Add(val);


					boxNo = ((r / 3) * 3) + (c / 3);
					if (boxes[boxNo].Contains(val))
						return false;
					boxes[boxNo].Add(val);

				}
			}
			return true;
		}
	}
}
