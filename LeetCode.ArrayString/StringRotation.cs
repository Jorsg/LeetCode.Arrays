using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class StringRotation
	{
		public static bool isSubString(string s1, string s2)
		{
			if (s1.Length != s2.Length)
			{
				return false;
			}
			string s1s1 = s1 + s1;
			return s1s1.Contains(s2);

		}

	}
}
