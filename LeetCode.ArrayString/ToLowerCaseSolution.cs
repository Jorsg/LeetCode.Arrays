using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	internal static class ToLowerCaseSolution
	{
		//Given a string s, return the string after replacing every uppercase letter with the same lowercase letter.

		//Example 1:		
		//Input: s = "Hello"
		//Output: "hello"

		//Example 2:		
		//Input: s = "here"
		//Output: "here"
		
		//Example 3:		
		//Input: s = "LOVELY"
		//Output: "lovely"

		public static string ToLowerCase(string s)
		{
			//Runtime: 101 ms
			//Memory: 40.60 MB
			return s.ToLower();
		}

		public static string ToLowerCaseLeetCodeSolution(string s)
		{
			//Runtime: 46 ms 
			//Memory: 36.7 MB
			string newString = "";
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] <= 'Z' && s[i] >= 'A')
				{
					int temp = (int)s[i];
					newString += (char)(temp + 32);
				}
				else
				{
					newString += s[i];
				}
			}
			return newString;
		}
	}
}
