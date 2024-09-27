using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public class KeyboardRow500LeetCode
	{
		//500. Keyboard Row
		//Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.

		//Example:
		//Input: ["Hello", "Alaska", "Dad", "Peace"]
		//Output: ["Alaska", "Dad"]

		//Explanation:
		//Only "Alaska" and "Dad" can be typed using letters of alphabet on only one row's of American keyboard.
		
		//Note:
		//You may use one character in the keyboard more than once.
		//You may assume the input string will only contain letters of alphabet.


		public static string[] FindWords(string[] words)
		{
			string row1 = "qwertyuiop";
			string row2 = "asdfghjkl";
			string row3 = "zxcvbnm";

			var result = new List<string>();
			foreach (string word in words)
			{
				if (IsInRow(word, row1) || IsInRow(word, row2) || IsInRow(word, row3))
				{
					result.Add(word);
				}
			}

			return result.ToArray();
		}

		private static bool IsInRow(string word, string row)
		{
			foreach (var c in word)
			{
				if (!row.Contains(c.ToString().ToLower()))
				{
					return false;
				}
			}
			return true;
		}


	}
}
