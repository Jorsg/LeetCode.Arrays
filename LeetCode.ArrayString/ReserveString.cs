using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class ReserveString
	{
		//344. Reverse String
		//Write a function that reverses a string. The input string is given as an array of characters s.
		//You must do this by modifying the input array in-place with O(1) extra memory.

		//Example 1:
		//Input: s = ["h","e","l","l","o"]
		//Output: ["o","l","l","e","h"]
		public void ReverseString(char[] s)
		{
			//Runtime: 226 ms
			//Memory Usage: 124.5 MB
			int left =0;
			int right = s.Length -1;
			while (left < right)
			{
				char temp = s[left];
				s[left++] = s[right];
				s[right--] = temp;
			}
		}
	}
}
