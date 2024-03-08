using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class MaximumNestingDepthParentheses
	{
		private readonly static char left = '(';

		private readonly static char right = ')';
		public static int MaxDepth(string s)
		{
			var z = 0;
			var max = 0;

            for (int i = 0; i < s.Length; i++)
            {
				if (s[i] == left)
				{
					z++;
					max = Math.Max(max, z);
				}
				else if (s[i] == right)
				{
					z--;
					max = Math.Max(max, z);
				}
            }

			return max;
        }
	}
}
