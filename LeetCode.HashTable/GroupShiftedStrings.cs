using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.HashTable
{
	internal class GroupShiftedStrings
	{
		//249. Group Shifted Strings
		//We can shift a string by shifting each of its letters to its successive letter.

		//For example, "abc" can be shifted to be "bcd".
		//We can keep shifting the string to form a sequence.
		
		//For example, we can keep shifting "abc" to form the sequence: "abc" -> "bcd" -> ... -> "xyz".
		//Given an array of strings strings, group all strings[i] that belong to the same shifting sequence.You may return the answer in any order.
		
		//Example 1:		
		//Input: strings = ["abc", "bcd", "acef", "xyz", "az", "ba", "a", "z"]
		//Output: [["acef"], ["a","z"], ["abc","bcd","xyz"], ["az","ba"]]

		public IList<IList<string>> GroupStrings(string[] strings)
		{
			var dict = new Dictionary<string, List<string>>();
			foreach (string s in strings)
			{
				var sb = new StringBuilder();
				for (int i = 1; i < s.Length; i++)
				{
					char prev = s[i - 1];
					char cur = s[i];
					var diff = (cur - prev + 26) % 26;
					sb.Append(diff);
					sb.Append("-");
				}
				var temp = sb.ToString();
				if (string.IsNullOrEmpty(temp))
					temp = "placeholder";
				if (!dict.ContainsKey(temp))
					dict.Add(temp, new List<string>());
				dict[temp].Add(s);
			}
			var list = new List<IList<string>>();
			foreach (var item in dict)
			{
				list.Add(new List<string>(item.Value));
			}

			return list;
		}

	}
}
