using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public class WordPattern290LeetCode
	{
		//290. Word Pattern
		//Given a pattern and a string s, find if s follows the same pattern.
		//Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

		//Example 1:
		//Input: pattern = "abba", s = "dog cat cat dog"
		//Output: true

		//Example 2:
		//Input: pattern = "abba", s = "dog cat cat fish"
		//Output: false

		public bool WordPattern(string pattern, string s)
		{
			var arry = s.Split(" ");
			bool result = true;

			if (pattern.Length != arry.Length) return false;

			var dict = new Dictionary<char, string>();

			for (int i = 0; i < pattern.Length; i++)
			{
				if (dict.ContainsKey(pattern[i]))
				{
					if (dict[pattern[i]] != arry[i])
					{
						result = false;
					}
				}
				else if (dict.Values.Contains(arry[i]))
				{
					result = false;
				}
				else
				{
					dict.Add(pattern[i], arry[i]);
				}
			}

			return result;
		}

	}
}
