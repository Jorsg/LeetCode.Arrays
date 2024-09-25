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
			bool isSubString = false;

			char[] s1Array = s1.ToCharArray();
			char[] s2Array = s2.ToCharArray();
			for (int i = 0; i < s1Array.Length; i++)
			{
				for (int j = 0; j < s2Array.Length; j++)
				{
					if (s1Array[i] == s2Array[j])
					{
						isSubString = true;
						break;
					}
				}


			}
			return isSubString;
		}

	}
}
