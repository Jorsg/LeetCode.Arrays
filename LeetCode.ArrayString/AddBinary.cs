using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public static class AddBinary
	{
		//67. Add Binary
		//Given two binary strings a and b, return their sum as a binary string.
		//Example 1:
		//Input: a = "11", b = "1"
		//Output: "100"
		public static string AddBinaryExercesi(string a, string b)
		{
			//Runtime: 79 ms
			//Memory Usage: 39.3 MB
			var sum = new List<int>();
			for (int i = a.Length -1, j = b.Length -1, carry = 0; i >= 0 || j>= 0 || carry > 0;)
			{
				var firtDigit = i >= 0 ? a[i--] - '0' : 0;
				var seconDigt = j >= 0 ? b[j--] - '0' : 0;
				var sumDigit = firtDigit + seconDigt + carry;
				carry = sumDigit / 2;
				sum.Add(sumDigit % 2);
			}
			sum.Reverse();
			return String.Concat(sum);
		}
	}
}
