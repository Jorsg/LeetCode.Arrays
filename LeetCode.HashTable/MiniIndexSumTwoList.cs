using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	internal class MiniIndexSumTwoList
	{

		//599. Minimum Index Sum of Two Lists
		//Given two arrays of strings list1 and list2, find the common strings with the least index sum.
		//A common string is a string that appeared in both list1 and list2.
		//A common string with the least index sum is a common string such that if it appeared at list1[i] and list2[j] then i + j should be the minimum value among all the other common strings.
		//Return all the common strings with the least index sum. Return the answer in any order.

		//Example 1:

		//Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["Piatti","The Grill at Torrey Pines","Hungry Hunter Steakhouse","Shogun"]
		//Output: ["Shogun"]
		//Explanation: The only common string is "Shogun".

		//Example 2:
		//Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["KFC","Shogun","Burger King"]
		//Output: ["Shogun"]
		//Explanation: The common string with the least index sum is "Shogun" with index sum = (0 + 1) = 1.

		public string[] FindRestaurant(string[] list1, string[] list2)
		{
			//Runtime: 203 ms
			//Memory Usage: 63.4 MB

			Dictionary<string, int> dict = new Dictionary<string, int>();
			for (int i = 0; i < list1.Length; i++)
			{
				for (int j = 0; j < list2.Length; j++)
				{
					if (list1[i] == list2[j])
					{
						dict.Add(list1[i], i + j);
					}
				}
			}
			int min = dict.Min(x => x.Value);
			return dict.Where(x => x.Value == min).Select(x => x.Key).ToArray();
		}
	}
}
