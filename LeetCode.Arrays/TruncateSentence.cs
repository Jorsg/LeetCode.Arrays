using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	internal static class TruncateSentence
	{

		//1816. Truncate Sentence
		public static string TruncateSentenceExce(string s, int k)
		{
			string result = string.Empty;
			string[] chars = s.Split(" ");
			int cont = 0;
            foreach (var item in chars)
            {
				if (cont < k) {
					result += $" {item}";
					cont++;
				}
            }

            return result;
		}
	}
}
