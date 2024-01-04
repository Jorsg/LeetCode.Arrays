using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class SortingtheSentence
	{
		//1859. Sorting the Sentence
		//A sentence is a list of words that are separated by a single space with no leading or trailing spaces. Each word consists of lowercase and uppercase English letters.

		//A sentence can be shuffled by appending the 1-indexed word position to each word then rearranging the words in the sentence.
		//For example, the sentence "This is a sentence" can be shuffled as "sentence4 a3 is2 This1" or "is2 sentence4 This1 a3".
		//Given a shuffled sentence s containing no more than 9 words, reconstruct and return the original sentence.
		
		//Example 1:
		//Input: s = "is2 sentence4 This1 a3"
		//Output: "This is a sentence"
		//Explanation: Sort the words in s to their original positions "This1 is2 a3 sentence4", then remove the numbers.
		public static string SortSentence(string s)
		{
			//Runtime: 64 ms
			//Memory: 38.52 MB
			string[] sentence = s.Split(" ");
			string result = string.Empty;
			sentence = sentence.OrderBy(x => x[x.Length - 1]).ToArray();
			foreach (var word in sentence)
			{
				result += word.Remove(word.Length - 1) + " ";
			}
			return result.Trim();
		}
	}
}
