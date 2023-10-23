using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class LongestCommonPrefix
	{
		public string LongestCommonPrefix_Excercise(string[] strs)
		{
			//Runtime: 98 ms
			// Memory: 40.37 MB
			if (strs.Length == 0) return "";

			String prefix = strs[0];
			for (int i = 1; i < strs.Length; i++)
			{
				while (strs[i].IndexOf(prefix) != 0)
				{
					prefix = prefix.Substring(0, prefix.Length - 1);
					if (prefix == "") return "";

			    }
			}

			return prefix;
		}
	}
}
