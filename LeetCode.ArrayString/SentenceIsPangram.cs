using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class SentenceIsPangram
	{
		//1832. Check if the Sentence Is Pangram
		//A pangram is a sentence where every letter of the English alphabet appears at least once.

		//Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.
		
		//Example 1:		
		//Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
		//Output: true
		//Explanation: sentence contains at least one of every letter of the English alphabet.

		//Example 2:
		//Input: sentence = "leetcode"
		//Output: false
		public static bool CheckIfPangram(string sentence)
		{
			//Runtime: 58 ms
			//Memory: 39.67S
			HashSet<char> hash = new HashSet<char>(sentence);
			if (hash.Count < 26)
				return false;
			else
				return true;


		}
	}
}
