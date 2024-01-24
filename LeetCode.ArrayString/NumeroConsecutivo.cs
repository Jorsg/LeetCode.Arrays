using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class NumeroConsecutivo
	{
		public static int NumeroGuay(int num)
		{
			int sum = 0;

			for (int i = 0; i < num; i++)
			{
				if (sum == num)
					break;
				else
					sum += i;
			}
			if (sum == num)
				return sum;
			else 
				return -1;
		}
	}
}
