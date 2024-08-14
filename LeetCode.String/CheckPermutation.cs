using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
	public static class CheckPermutation
	{

		// 1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the other.
		// BOOK CRAKING CODING INTERVIEW
		// Time complexity: O(n)
		public static bool IsPermutation(string s1, string s2)
		{
			if (s1.Length != s2.Length)
			{
				return false;
			}

			int[] letters = new int[128];
			foreach (char c in s1)
			{
				letters[c]++;
			}

			foreach (char c in s2)
			{
				letters[c]--;
				if (letters[c] < 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
