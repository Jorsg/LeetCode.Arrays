using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    public static class UniqueCharacters
    {
		// 1.1 Is Unique: Create algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
		// BOOK CRAKING CODING INTERVIEW
		// Time complexity: O(n)
		public static bool IsUnique(string s)
		{
			if (s.Length > 128)
			{
				return false;
			}

			bool[] charSet = new bool[128];
			for (int i = 0; i < s.Length; i++)
			{
				int val = s[i];
				if (charSet[val])
				{
					return false;
				}
				charSet[val] = true;
			}
			return true;
		}
	}
}
