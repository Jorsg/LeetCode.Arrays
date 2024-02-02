using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	internal static class LongestSubstringWithoutRepeatingCharacters
	{
		//3. Longest Substring Without Repeating Characters
		//Given a string s, find the length of the longest substring without repeating characters.
		
		//Example 1:		
		//Input: s = "abcabcbb"
		//Output: 3
		//Explanation: The answer is "abc", with the length of 3.

		//Example 2:		
		//Input: s = "bbbbb"
		//Output: 1
		//Explanation: The answer is "b", with the length of 1.

		//Example 3:	
		//Input: s = "pwwkew"
		//Output: 3
		//Explanation: The answer is "wke", with the length of 3.
		//Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
		public static int LengthOfLongestSubstring(string s)
		{
			//Runtime: 57 ms
			//Memory: 42.76 MB

			Dictionary<char, int> map = new Dictionary<char, int>();
			int left = 0, result = 0;

			for (int i = 0; i < s.Length; i++)
			{
				if (map.ContainsKey(s[i]))
					left = Math.Max(left, map[s[i]] + 1);

				result = Math.Max(result, i - left + 1);
				map[s[i]] = i;
			}
			return result;
		}
	}
}
