using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
	public static class ScoreofStringLeetCode
	{
		public static int ScoreOfString(string s)
		{
			var score = 0;

			for (int i = 1; i < s.Length; i++)
			{
				score += Math.Abs(s[i] - s[i - 1]);
			}
			return score;
		}
	}
}
