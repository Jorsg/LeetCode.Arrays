using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class StringRotation
	{
		//1.9 String Rotation: Assume you have a method isSubstring which checks if one word is a substring of another.
		//Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring (e.g., "waterbottle" is a rotation of"erbottlewat").
		//Time complexity: O(n)
		//Space complexity: O(n)
		//s1 = xy = waterbottle
		//x = wat
		//y = erbottle
		//s2 = yx = erbottlewat
		//s2 will always be a substring of s1s1
		//s1s1 = xyxy = waterbottlewaterbottle
		//s2 = yx = erbottlewat
		//s1s1 contains s2
		//s2 is a rotation of s1

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
