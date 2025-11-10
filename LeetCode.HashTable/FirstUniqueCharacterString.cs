using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Collections;

namespace LeetCode.HashTable
{
    public static class FirstUniqueCharacterString
    {
        //387. First Unique Character in a String
        //Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

        //Example 1:	
        //Input: s = "leetcode"
        //Output: 0

        //Example 2:		
        //Input: s = "loveleetcode"
        //Output: 2

        //Example 3:		
        //Input: s = "aabb"
        //Output: -1

        public static int firstUniqChar(string s)
        {
            //Runtime: 80 ms
            //Memory Usage: 55.3 MB
            Dictionary<char, List<int>> map = new Dictionary<char, List<int>>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!map.ContainsKey(c))
                    map.Add(c, new List<int>(new[] { i }));
                else
                {
                    map[c].Add(i);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (map[c].Count == 1)
                    return map[c][0];
            }
            return -1;
        }

        /// <summary>
        /// IsUnique
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
		public static bool IsUnique(string s)
        {
            bool result = true;
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(s[i]))
                    return false;

                set.Add(s[i]);

            }
            return result;
        }

        //169. Majority Element
        //Given an array nums of size n, return the majority element.
        //The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.

        //Example 1:	
        //Input: nums = [3, 2, 3]
        //Output: 3

        //Example 2:	
        //Input: nums = [2, 2, 1, 1, 1, 2, 2]
        //Output: 2

        public static int MajorityElement(int[] nums)
        {
            //Runtime: 91 ms
            //Memory Usage: 42.3 MB
            Array.Sort(nums);
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ans = nums[nums.Length / 2];
            }
            return ans;
        }
    }
}
