using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    public class ValidParenthesesLeetCode
    {
        //20. Valid Parentheses
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        //An input string is valid if:
        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Every close bracket has a corresponding open bracket of the same type.
        //Example 1:
        //Input: s = "()"
        //Output: true
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            bool result = false;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (c == '[')
                {
                    stack.Push('[');
                }
                else
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        result = false;
                    }
                }
            }
            if (stack.Count == 0)
                result = true;

            return result;
        }
    }
}
