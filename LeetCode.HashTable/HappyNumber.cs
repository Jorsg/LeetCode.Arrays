using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public class HappyNumber
	{
		//202. Happy Number
		//Write an algorithm to determine if a number n is happy.
		//A happy number is a number defined by the following process:
		//Starting with any positive integer, replace the number by the sum of the squares of its digits.
		//Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
		//Those numbers for which this process ends in 1 are happy.
		//Return true if n is a happy number, and false if not.

		//Example 1:
		//Input: n = 19
		//Output: true
		//Explanation:
		//12 + 92 = 82
		//82 + 22 = 68
		//62 + 82 = 100
		//12 + 02 + 02 = 1

		public bool IsHappy(int n)
		{
			//Runtime: 29 ms
			//Memory Usage: 29.2 MB
			HashSet<int> set = new HashSet<int>();
			while (n != 1)
			{
				string str = n.ToString();
				int sum = 0;
				foreach (var item in str)
				{
					int digit = item - '0';
					sum += digit * digit;
				}
				if (set.Contains(sum))
					return false;

				set.Add(sum);
				n = sum;
			}
			return true;
		}
	}
}
