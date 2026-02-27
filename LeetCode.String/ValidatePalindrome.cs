using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    public class ValidatePalindrome
    {
        //Given a string, determine if it is a palindrome considering only alphanumeric characters and ignoring cases.

        //Examples

        //Input:"A man, a plan, a canal: Panama"
        //Output:true

        //Input:"race a car"
        //Output:false

        //Pattern: Opposite ends → inward
        //Time: O(n)
        //Space: O(1)
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                while (left < right && !Char.IsLetterOrDigit(s[left])) left++;
                while (left < right && !Char.IsLetterOrDigit(s[right])) right--;
                if (Char.ToLower(s[left]) != char.ToLower(s[right]))
                    return false;
                left++;
                right--;
            }
            return true;
        }

    }
}
