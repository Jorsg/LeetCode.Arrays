using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.ArrayString
{
	internal static class TwoStringArraysEquivalent
	{
		//1662. Check If Two String Arrays are Equivalent

		//Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
		//
		//A string is represented by an array if the array elements concatenated in order forms the string.
		
		//Example 1:
		
		//Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
		//Output: true
		//Explanation:
		//word1 represents string "ab" + "c" -> "abc"
		//word2 represents string "a" + "bc" -> "abc"
		//The strings are the same, so return true.

		//Example 2:
				
		//Input: word1 = ["a", "cb"], word2 = ["ab", "c"]
		//Output: false

		//Example 3:		
		//Input: word1  = ["abc", "d", "defg"], word2 = ["abcddefg"]
		//Output: true

		public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
		{
			//Runtime: 70 ms
			//Memory: 42.85 MB
			string result1 = string.Empty;
			string result2 = string.Empty;
			bool ans = false;
			foreach (string word in word1)
			{
				result1 += word;
			}
			foreach (var word in word2)
			{
				result2 += word;
			}
			if (result1 == result2)
			{
				ans = true;
			}
			return ans;
		}
	}
}
