using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public static class MinimumNumberMovesSeatEveryone
	{
		public static int MinMovesToSeat(int[] seats, int[] students)
		{
			Array.Sort(seats);
			Array.Sort(students);
			int result = 0;
			for (int i = 0; i < seats.Length; i++)
			{
				result += Math.Abs(seats[i] - students[i]);
			}

			return result;
		}
	}
}
