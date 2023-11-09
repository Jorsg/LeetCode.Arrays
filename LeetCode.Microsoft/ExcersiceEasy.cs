﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Microsoft
{
	public static class ExcersiceEasy
	{
		//2235. Add Two Integers
		//Given two integers num1 and num2, return the sum of the two integers.

		//Example 1:
		//Input: num1 = 12, num2 = 5
		//Output: 17
		//Explanation: num1 is 12, num2 is 5, and their sum is 12 + 5 = 17, so 17 is returned.

		//Example 2:
		//Input: num1 = -10, num2 = 4
		//Output: -6
		//Explanation: num1 + num2 = -6, so -6 is returned.
		public static int Sum(int num1, int num2)
		{
			//Runtime: 11 ms
			//Memory: 26.49
			return (num1 + num2);
		}


		public static string DefangIPaddr(string address)
		{
			//Runtime: 64ms
			//Memory: 36.94 MB
			string ip = address.Replace(".", "[.]");
            return ip;
		}


		//771. Jewels and Stones
		//You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in
		//stones is a type of stone you have. You want to know how many of the stones you have are also jewels.
		//Letters are case sensitive, so "a" is considered a different type of stone from "A".

		//Example 1:
		//Input: jewels = "aA", stones = "aAAbbbb"
		//Output: 3
		
		public static int NumJewelsInStones(string jewels, string stones)
		{
			//Runtime: 51 ms
			//Memory: 37.31 MB
			int gems = 0;
			for (int i = 0; i < jewels.Length; i++)
			{
				for (int j = 0; j < stones.Length; j++)
				{
					if (jewels[i] == stones[j])
						gems++;
				}
			} 
            return gems;
		}


	}
}
