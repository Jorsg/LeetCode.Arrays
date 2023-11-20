using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public static class RemoveVowelsString
	{
		//1119. Remove Vowels from a String
		//Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

		//Example 1:
		//Input: s = "leetcodeisacommunityforcoders"
		//Output: "ltcdscmmntyfrcdrs"
		//Example 2:
	
		//Input: s = "aeiou"
		//Output:

		public static string RemoveVowels(string s)
		{
			string vowels = "aeiou";
			return s = new string(s.Where(c => !vowels.Contains(c)).ToArray());
		}
	}
}
