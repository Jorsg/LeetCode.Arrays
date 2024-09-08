using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public class ValidAnagram
	{
		public static bool IsAnagram(string s, string t)
		{
			if(s.Length != t.Length) return false;
			Dictionary<char, int> map = new Dictionary<char, int>();
			
			for(int i = 0;i < s.Length; i++)
			{
				if (map.ContainsKey(s[i]))
					map[s[i]]++;
				else
					map[s[i]] = 1;
			}
			for(int i = 0; i < t.Length; i++)
			{
				if (map.ContainsKey(t[i]))
					if (map[t[i]] > 0)
						map[t[i]]--;
					else
						return false;
				else
					return false;
			}
			
			return true;
		}
	}
}
