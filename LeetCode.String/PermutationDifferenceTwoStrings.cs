using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
	public static class PermutationDifferenceTwoStrings
	{
		public static int FindPermutationDifference(string s, string t)
		{
			int result =0;
			for (int i = 0; i < s.Length; i++)
            {
				result += Math.Abs(s.IndexOf(s[i]) - t.IndexOf(s[i]));
			}

			return result;
		}
	}
}
