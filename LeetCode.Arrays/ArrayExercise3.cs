using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace LeetCode.Arrays
{
	public static class ArrayExercise3
	{
		//1389. Create Target Array in the Given Order
		//Given two arrays of integers nums and index. Your task is to create target array under the following rules:
		//Initially target array is empty.
		//From left to right read nums[i] and index[i], insert at index index[i] the value nums[i] in target array.
		//Repeat the previous step until there are no elements to read in nums and index.
		//Return the target array.
		//It is guaranteed that the insertion operations will be valid.

		//Example 1:
		//Input: nums = [0,1,2,3,4], index = [0,1,2,2,1]
		//Output: [0,4,1,3,2]
		//Explanation:
		//nums index     target
		//0            0        [0]
		//1            1        [0,1]
		//2            2        [0,1,2]
		//3            2        [0,1,3,2]
		//4            1        [0,4,1,3,2]
		public static int[] CreateTargetArray(int[] nums, int[] index)
		{
			//Runtime: 128 ms
			//Memory: 42.52 MB
			List<int> target = new List<int>();
			for (int i = 0; i < nums.Length; i++)
			{
				target.Insert(index[i], nums[i]);
			}
			return target.ToArray();
		}


		//1313. Decompress Run-Length Encoded List
		//We are given a list nums of integers representing a list compressed with run-length encoding.
		//Consider each adjacent pair of elements[freq, val] = [nums[2 * i], nums[2 * i + 1]](with i >= 0).For each such pair, there are freq elements with value val concatenated in a sublist.Concatenate all the sublists from left to right to generate the decompressed list.
		//Return the decompressed list.

		//Example 1:
		//
		//Input: nums = [1,2,3,4]
		//		Output: [2,4,4,4]
		//		Explanation: The first pair[1, 2] means we have freq = 1 and val = 2 so we generate the array[2].
		//The second pair[3, 4] means we have freq = 3 and val = 4 so we generate[4, 4, 4].
		//At the end the concatenation[2] + [4,4,4] is [2,4,4,4].
		public static int[] DecompressRLElist(int[] nums)
		{
			//Runtime: 129 ms
			//Memory: 47.93 MB
			IList<int> result = new List<int>();
			for (int i = 0; i < nums.Length; i += 2)
			{
				int feq = nums[i];
				int val = nums[i + 1];
				for (int j = 1; j <= feq; j++)
				{
					result.Add(val);
				}
			}
			return result.ToArray();
		}


		//1773. Count Items Matching a Rule
		//You are given an array items, where each items[i] = [typei, colori, namei] describes the type, color, and name of the ith item.
		//You are also given a rule represented by two strings, ruleKey and ruleValue.
		//The ith item is said to match the rule if one of the following is true:

		//ruleKey == "type" and ruleValue == typei.
		//ruleKey == "color" and ruleValue == colori.
		//ruleKey == "name" and ruleValue == namei.
		//Return the number of items that match the given rule.

		//Example 1:

		//Input: items = [["phone", "blue", "pixel"], ["computer","silver","lenovo"], ["phone","gold","iphone"]], ruleKey = "color", ruleValue = "silver"
		//Output: 1
		//Explanation: There is only one item matching the given rule, which is ["computer","silver","lenovo"].

		//Example 2:		
		//Input: items = [["phone","blue","pixel"],["computer","silver","phone"],["phone","gold","iphone"]], ruleKey = "type", ruleValue = "phone"
		//Output: 2
		//Explanation: There are only two items matching the given rule, which are["phone", "blue", "pixel"] and["phone", "gold", "iphone"]. Note that the item["computer", "silver", "phone"] does not match.
		public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
		{
			//Runtime: 136 ms
			//Memory: 54.00 MB
			int itemsVal = 0;
			foreach (var item1 in items)
			{

				for (int i = 0; i < item1.Count; i++)
				{
					if (ruleKey == "color" && ruleValue == item1[1])
					{ itemsVal++; break; }
					else if (ruleKey == "type" && ruleValue == item1[0])
					{ itemsVal++; break; }
					else if (ruleKey == "name" && ruleValue == item1[2])
					{ itemsVal++; break; }
				}
			}
			return itemsVal;
		}


		//1678. Goal Parser Interpretation
		//You own a Goal Parser that can interpret a string command. The command consists of an alphabet of "G", "()" and/or "(al)" in some order.
		//The Goal Parser will interpret "G" as the string "G", "()" as the string "o", and "(al)" as the string "al". The interpreted strings are then concatenated in the original order.

		//Given the string command, return the Goal Parser's interpretation of command.		
	
		//Example 1:	
		//Input: command = "G()(al)"
		//Output: "Goal"
		//Explanation: The Goal Parser interprets the command as follows:
		//G -> G
		//() -> o
		//(al) -> al
		//The final concatenated result is "Goal".

		//Example 2:
	
		//Input: command = "G()()()()(al)"
		//Output: "Gooooal"
		//Example 3:
	
		//Input: command = "(al)G(al)()()G"
		//Output: "alGalooG"

		public static string Interpret(string command)
		{
			//Runtime: 66 ms
			//Memory: 36.00 MB
			string result = command.Replace("()", "o").Replace("(al)", "al");
			return result;
		}
	}
}
