using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class DecodeMessage
	{
		//2325. Decode the Message
		//You are given the strings key and message, which represent a cipher key and a secret message, respectively. The steps to decode message are as follows:

		//Use the first appearance of all 26 lowercase English letters in key as the order of the substitution table.
		//Align the substitution table with the regular English alphabet.
		//Each letter in message is then substituted using the table.
		//Spaces ' ' are transformed to themselves.
		//For example, given key = "happy boy"(actual key would have at least one instance of each letter in the alphabet), we have the partial substitution table of ('h' -> 'a', 'a' -> 'b', 'p' -> 'c', 'y' -> 'd', 'b' -> 'e', 'o' -> 'f').
		//Return the decoded message.

		//Example 1:
		//Input: key = "the quick brown fox jumps over the lazy dog", message = "vkbs bs t suepuv"
		//Output: "this is a secret"
		//Explanation: The diagram above shows the substitution table.
		//It is obtained by taking the first appearance of each letter in "the quick brown fox jumps over the lazy dog".
		public static string DecodeMessageExercise(string key, string message)
		{
			//Runtime: 54 ms
			//Memory: 40.61 MB
			StringBuilder sb = new StringBuilder();
			char[] keyToActual = new char[128];
			keyToActual[' '] = ' ';
			char currChar = 'a';


			// First foreach it create the alphabet
			foreach (char c in key.ToCharArray())
			{
				if (keyToActual[c] == 0)
					keyToActual[c] = currChar++; 
			}
			
			foreach (char c in message.ToCharArray())
			{
				sb.Append(keyToActual[c]);
			}

			return sb.ToString();
		}
	}
}
