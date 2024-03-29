﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.ArrayString
{
	//1021. Remove Outermost Parentheses
	//A valid parentheses string is either empty "", "(" + A + ")", or A + B, where A and B are valid parentheses strings, and + represents string concatenation.

	//For example, "", "()", "(())()", and "(()(()))" are all valid parentheses strings.
	//A valid parentheses string s is primitive if it is nonempty, and there does not exist a way to split it into s = A + B, with A and B nonempty valid parentheses strings.
	//Given a valid parentheses string s, consider its primitive decomposition: s = P1 + P2 + ... + Pk, where Pi are primitive valid parentheses strings.
	//Return s after removing the outermost parentheses of every primitive string in the primitive decomposition of s.
	
	//Example 1:
	
	//Input: s = "(()())(())"
	//Output: "()()()"
	//Explanation: 
	//The input string is "(()())(())", with primitive decomposition "(()())" + "(())".
	//After removing outer parentheses of each part, this is "()()" + "()" = "()()()".

	//Example 2:
	
	//Input: s = "(()())(())(()(()))"
	//Output: "()()()()(())"
	//Explanation: 
	//The input string is "(()())(())(()(()))", with primitive decomposition "(()())" + "(())" + "(()(()))".
	//After removing outer parentheses of each part, this is "()()" + "()" + "()(())" = "()()()()(())".

	//Example 3:
	
	//Input: s = "()()"
	//Output: ""
	//Explanation: 
	//The input string is "()()", with primitive decomposition "()" + "()".
	//After removing outer parentheses of each part, this is "" + "" = "".
	
	//Constraints:
	//
	//1 <= s.length <= 105
	//s[i] is either '(' or ')'.
	//s is a valid parentheses string.

	internal static class RemoveOutermostParentheses
	{
		public static string RemoveOuterParenthesesExercise(string s)
		{
			//Runtime: 47 ms
			//Memory: 41.14 MB

			StringBuilder decomps = new StringBuilder();
			StringBuilder builder = new StringBuilder();
			int counter = 0;
			foreach (var c in s)
			{
				builder.Append(c);
				if (c == '(')
					counter++;
				if (c == ')')
					counter--;
				if (counter == 0)
				{
					decomps.Append(builder.ToString(1, builder.Length - 2));
					builder.Clear();
				}
			}
			return decomps.ToString();
		}
	}
}
