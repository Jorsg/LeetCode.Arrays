using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public static class FindMinimumOperationsMakeAllElementsDivisibleThree
	{
		public static int MinimumOperations(int[] nums)
		{
			int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
				if (nums[i] % 3 == 0)
					total += 0;
				else if (nums[i] % 3 == 1)
					total ++;
				else if (nums[i] % 3 == 2)
					total ++;
			}
			return total;
		}
	}
}
