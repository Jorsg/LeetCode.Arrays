using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.ArrayString
{

	internal static class SplitStringBalanced
	{

		//1221. Split a String in Balanced Strings
		//Balanced strings are those that have an equal quantity of 'L' and 'R' characters.

		//Given a balanced string s, split it into some number of substrings such that:
		//
		//Each substring is balanced.
		//Return the maximum number of balanced strings you can obtain.
		
		//Example 1:
		
		//Input: s = "RLRRLLRLRL"
		//Output: 4
		//Explanation: s can be split into "RL", "RRLL", "RL", "RL", each substring contains same number of 'L' and 'R'.
		public static int BalancedStringSplit(string s)
		{
			int ans = 0;
			string balance = string.Empty;
			int left = 0, right = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == 'R')
					right++;
				else
					left++;


				if (right == left)
				{
					ans++;
					right = 0; left = 0;
				}
			}
			return ans;
		}
	}
}
