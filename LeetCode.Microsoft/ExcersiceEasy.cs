using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Microsoft
{
	public static class ExcersiceEasy
	{
		//2235. Add Two Integers
		//Given two integers num1 and num2, return the sum of the two integers.

		//Example 1:
		//Input: num1 = 12, num2 = 5
		//Output: 17
		//Explanation: num1 is 12, num2 is 5, and their sum is 12 + 5 = 17, so 17 is returned.

		//Example 2:
		//Input: num1 = -10, num2 = 4
		//Output: -6
		//Explanation: num1 + num2 = -6, so -6 is returned.
		public static int Sum(int num1, int num2)
		{
			//Runtime: 11 ms
			//Memory: 26.49
			return (num1 + num2);
		}


		public static string DefangIPaddr(string address)
		{
			//Runtime: 64ms
			//Memory: 36.94 MB
			string ip = address.Replace(".", "[.]");
			return ip;
		}


		//771. Jewels and Stones
		//You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in
		//stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
		//Letters are case sensitive, so "a" is considered a different type of stone from "A".

		//Example 1:
		//Input: jewels = "aA", stones = "aAAbbbb"
		//Output: 3

		public static int NumJewelsInStones(string jewels, string stones)
		{
			//Runtime: 51 ms
			//Memory: 37.31 MB
			int gems = 0;
			for (int i = 0; i < jewels.Length; i++)
			{
				for (int j = 0; j < stones.Length; j++)
				{
					if (jewels[i] == stones[j])
						gems++;
				}
			}
			return gems;
		}


		//1528. Shuffle String
		//You are given a string s and an integer array indices of the same length. The string s will be shuffled such
		//that the character at the ith position moves to indices[i] in the shuffled string.
		//Return the shuffled string.

		//Example 1:
		//Input: s = "codeleet", indices = [4,5,6,7,0,2,1,3]
		//Output: "leetcode"
		//Explanation: As shown, "codeleet" becomes "leetcode" after shuffling.
		public static string RestoreString(string s, int[] indices)
		{
			//Runtime: 92 ms
			//Memory: 42.31 MB
			StringBuilder sb = new StringBuilder(s);
			for (int i = 0; i < indices.Length; i++)
			{
				sb[indices[i]] = s[i];
			}
			return sb.ToString();
		}



		//859. Buddy Strings
		//Given two strings s and goal, return true if you can swap two letters in s so the result is equal to goal, otherwise, return false.
		//Swapping letters is defined as taking two indices i and j (0-indexed) such that i != j and swapping the characters at s[i] and s[j].
		//For example, swapping at indices 0 and 2 in "abcd" results in "cbad".

		//Example 1:
		//Input: s = "ab", goal = "ba"
		//Output: true
		//Explanation: You can swap s[0] = 'a' and s[1] = 'b' to get "ba", which is equal to goal.
		//Example 2:
		
		//Input: s = "ab", goal = "ab"
		//Output: false
		//Explanation: The only letters you can swap are s[0] = 'a' and s[1] = 'b', which results in "ba" != goal.
		
		public static bool buddyStrings(string s, string goal)
		{
			//Runtime: 67 ms
			//Memory: 39.00 MB

			if (s.Length != goal.Length || s.Length < 2 || goal.Length < 2)
				return false;


			if (s.Equals(goal))
			{
				HashSet<char> uniqueChars = new HashSet<char>();
				return uniqueChars.Count < s.Length;
			}

			List<int> diffIndices = new List<int>();
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] != goal[i])
					diffIndices.Add(i);
				if (diffIndices.Count > 2)
					return false;
			}
			if (diffIndices.Count != 2)
				return false;

			return s[diffIndices[0]] == goal[diffIndices[1]] && s[diffIndices[1]] == goal[diffIndices[0]];
		}




	}
}
