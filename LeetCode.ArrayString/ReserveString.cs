using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class ReserveString
	{
		//344. Reverse String
		//Write a function that reverses a string. The input string is given as an array of characters s.
		//You must do this by modifying the input array in-place with O(1) extra memory.

		//Example 1:
		//Input: s = ["h","e","l","l","o"]
		//Output: ["o","l","l","e","h"]
		public void ReverseString(char[] s)
		{
			//Runtime: 226 ms
			//Memory Usage: 124.5 MB
			int left = 0;
			int right = s.Length - 1;
			while (left < right)
			{
				char temp = s[left];
				s[left++] = s[right];
				s[right--] = temp;
			}
		}

		//151. Reverse Words in a String
		//Given an input string s, reverse the order of the words.
		//A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
		//Return a string of the words in reverse order concatenated by a single space.
		//Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.
		public string ReverseWords(string s)
		{
			//Runtime: 80 ms
			//Memory Usage: 38.8 MB
			string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
			Array.Reverse(words);
			return string.Join(" ", words);
		}

		//557. Reverse Words in a String III
		//Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

		//Example 1:
		//Input: s = "Let's take LeetCode contest"
		//Output: "s'teL ekat edoCteeL tsetnoc"
		public string ReverseWordsIII(string s)
		{
			//Runtime: 81 ms
			//Memory Usage: 47.2 MB
			string[] words = s.Split();
			string[] reversedWords = new string[words.Length];
			for (int i = 0; i < words.Length; i++)
			{
				char[] wordChar = words[i].ToCharArray();
				Array.Reverse(wordChar);
				reversedWords[i] = new string(wordChar);
			}
			return string.Join("", reversedWords);
		}
	}
}
