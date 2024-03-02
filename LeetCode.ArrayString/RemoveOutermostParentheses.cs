using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class RemoveOutermostParentheses
	{
		public static string RemoveOuterParenthesesExercise(string s)
		{
			StringBuilder decomps = new StringBuilder();
			StringBuilder builder = new StringBuilder();
			int counter = 0;
            foreach (var c in s)
            {
				builder.Append(c);
				if(c == '(')
					counter++;
				if(c == ')')
					counter--;
				if(counter == 0)
				{
					decomps.Append(builder.ToString(1, builder.Length -2));
					builder.Clear();
				}
            }
			return decomps.ToString();
        }
	}
}
