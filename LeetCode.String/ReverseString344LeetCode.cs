using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
	public class ReverseString344LeetCode
	{
		//344. Reverse String
		//Write a function that reverses a string. The input string is given as an array of characters s.

		//Example 1:
		//Input: s = ["h","e","l","l","o"]
		//Output: ["o","l","l","e","h"]
		public static char[] ReverseString(char[] s)
		{
			//Runtime: 340 ms
			//Memory Usage: 34.7 MB
			int left = 0;			
			int right = s.Length - 1;
			while (left < right)
			{
				char temp = s[left];
				s[left] = s[right];
				s[right] = temp;
				left++;
				right--;
				
			}
			return s;
		}
	}
}
