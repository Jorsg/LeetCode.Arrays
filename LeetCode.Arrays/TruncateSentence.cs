using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	internal static class TruncateSentence
	{

		//1816. Truncate Sentence

		//A sentence is a list of words that are separated by a single space with no leading or trailing spaces. Each of the words consists of only uppercase and lowercase English letters (no punctuation).
		//For example, "Hello World", "HELLO", and "hello world hello world" are all sentences.
		//You are given a sentence s​​​​​​ and an integer k​​​​​​.You want to truncate s​​​​​​ such that it contains only the first k​​​​​​ words.Return s​​​​​​ after truncating it.

		//Example 1:

		//Input: s = "Hello how are you Contestant", k = 4
		//Output: "Hello how are you"
		//Explanation:
		//The words in s are["Hello", "how" "are", "you", "Contestant"].
		//The first 4 words are["Hello", "how", "are", "you"].
		//Hence, you should return "Hello how are you".

		public static string TruncateSentenceExce(string s, int k)
		{

			//Runtime: 70 ms
			//Memory: 38.3 MB
			string result = string.Empty;
			string[] chars = s.Split(" ");
			int cont = 0;
			foreach (var item in chars)
			{
				if (cont < k)
				{
					result += $" {item}";
					cont++;
				}
			}

			return result.Trim();
		}
	}
}
