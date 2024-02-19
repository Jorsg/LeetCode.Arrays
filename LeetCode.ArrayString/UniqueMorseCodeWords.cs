using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.ArrayString
{
	internal static class UniqueMorseCodeWords
	{
		//International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:
		//'a' maps to ".-",
		//'b' maps to "-...",
		//'c' maps to "-.-.", and so on.
		//For convenience, the full table for the 26 letters of the English alphabet is given below:
		
		//[".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."]
		//Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.
		
		//For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
		//Return the number of different transformations among all words we have.
		
		//Example 1:		
		//Input: words = ["gin", "zen", "gig", "msg"]
		//Output: 2
		//Explanation: The transformation of each word is:
		//"gin" -> "--...-."
		//"zen" -> "--...-."
		//"gig" -> "--...--."
		//"msg" -> "--...--."
		//There are 2 different transformations: "--...-." and "--...--.".

		//Example 2:		
		//Input: words = ["a"]
		//Output: 1
		public static int UniqueMorseRepresentations(string[] words)
		{
			//Runtime: 52 ms
			//Memory: 40.44

			string[] morse = new string[]
				{ ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.." };

			HashSet<string> result = new HashSet<string>();
			foreach (string word in words)
			{
				StringBuilder sb = new StringBuilder();
				foreach (char c in word.ToCharArray())
				{
					sb.Append(morse[c - 'a']);
				}
				result.Add(sb.ToString());
			}
			return result.Count;
		}
	}
}
