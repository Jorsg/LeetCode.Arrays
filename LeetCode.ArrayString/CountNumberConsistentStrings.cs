using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class CountNumberConsistentStrings
	{
		public static int CountConsistentStrings(string allowed, string[] words)
		{
			int count = 0;
			foreach (var word in words)
			{
				count++;
				foreach (var letter in word)
				{
					if (!allowed.Contains(letter))
					{
						count--;
						break;
					}
				}
			}
			return count;
		}
	}
}
