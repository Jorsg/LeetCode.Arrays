using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	internal static class GroupAnagramsSolution
	{
		//49. Group Anagrams
		//Given an array of strings strs, group the anagrams together. You can return the answer in any order.

		//An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
		
		//Example 1:
		
		//Input: strs = ["eat","tea","tan","ate","nat","bat"]
		//Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

		//Example 2:		
		//Input: strs = [""]
		//Output: [[""]]

		//Example 3:
		//Input: strs = ["a"]
		//Output: [["a"]]
		public static IList<IList<string>> GroupAnagrams(string[] strs)
		{
			//Runtime: 319 ms
			//Memory:60 MB
			if (strs == null || strs.Length == 0) return new List<IList<string>>();

			Dictionary<string, List<string>> resultAnagram = new Dictionary<string, List<string>>();

			foreach (string str in strs)
			{
				int[] charCount = new int[26];
				foreach (char c in str)
				{
					charCount[c - 'a']++;
				}
				StringBuilder keybuilder = new StringBuilder();
				foreach (int count in charCount)
				{
					keybuilder.Append(count).Append(',');
				}
				string key = keybuilder.ToString();

				if (!resultAnagram.ContainsKey(key))
				{
					resultAnagram[key] = new List<string>();
				}
				resultAnagram[key].Add(str);
			}
			List<IList<string>> list = new List<IList<string>>(resultAnagram.Values);
			return list;
		}

		public static IList<IList<string>> GroupAnagramsLeetCodeBetsSolution(string[] strs)
		{
			Dictionary<string, IList<string>> dictionary = new();

			foreach (string str in strs)
			{
				char[] characters = str.ToArray();
				Array.Sort(characters);

				string key = new string(characters);
				if (dictionary.ContainsKey(key))
				{
					dictionary[key].Add(str);
				}
				else
				{
					dictionary[key] = new List<string>(){
					str,
					};
				}
			}

			return dictionary.Values.ToList();
		}
	}
}
