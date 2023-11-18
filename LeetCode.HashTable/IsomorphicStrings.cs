using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public class IsomorphicStrings
	{
		//205. Isomorphic Strings
		//Given two strings s and t, determine if they are isomorphic.
		//Two strings s and t are isomorphic if the characters in s can be replaced to get t.
		//All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to
		//the same character, but a character may map to itself.

		//Example 1:
		//Input: s = "egg", t = "add"
		//Output: true
		//Example 2:
		//Input: s = "foo", t = "bar"
		//Output: false

		public bool IsIsomorphic(string s, string t)
		{
			//Runtime: 77 ms
			//Memory Usage: 39.8 MB
			if (s.Length != t.Length) return false;

			Dictionary<char, char> mapping = new Dictionary<char, char>();
			HashSet<char> keys = new HashSet<char>();

			for(int i = 0; i < s.Length; i++)
			{
				char c = s[i];
				char c2 = t[i];
				if(mapping.ContainsKey(c))
				{
					if (mapping[c]!= c2)
						return false;
				}
				else
				{
					if (keys.Contains(c2)) 
						return false;
				}
				mapping[c] = c2;
				keys.Add(c2);
			}
			return true;
		}
		
	}
}
