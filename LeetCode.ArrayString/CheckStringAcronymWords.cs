using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class CheckStringAcronymWords
	{
		//2828. Check if a String Is an Acronym of Words
		//Given an array of strings words and a string s, determine if s is an acronym of words.

		//The string s is considered an acronym of words if it can be formed by concatenating the first character of each string in words in order.For example, "ab" can be formed from["apple", "banana"], but it can't be formed from ["bear", "aardvark"].
		
		//Return true if s is an acronym of words, and false otherwise.
		
		//Example 1:
		//Input: words = ["alice","bob","charlie"], s = "abc"
		//Output: true
		//Explanation: The first character in the words "alice", "bob", and "charlie" are 'a', 'b', and 'c', respectively.Hence, s = "abc" is the acronym.
		public static bool IsAcronym(IList<string> words, string s)
		{
			//Runtime: 76 ms
			//Memory: 50.29 MB
			bool response = true;
			if (words.Count != s.Length)
				return response = false;

			for (int i = 0; i < words.Count; i++)
			{
				if (s[i] != words[i][0])
				{
					response = false;
				}
			}

			return response;
		}
	}
}
