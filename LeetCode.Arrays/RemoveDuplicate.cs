using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class RemoveDuplicate
    {
        //#04 Remove Duplicates from Sorted Array
        //Easy

        //Given a sorted array, remove duplicates in-place so each element appears only once. Return the new length.

        //Examples
        //Input: [1,1,2]
        //Output: 2 → [1,2,...]

        //Input: [0,0,1,1,1,2,2,3,3,4]
        //Output: 5 → [0,1,2,3,4,...]

        //Pattern: Same direction (slow & fast)
        //Time: O(n)
        //Space: O(1)

        //Hint: 
        //Use a slow pointer for the write position and a fast pointer to scan ahead. When fast finds a new value, write it at slow's position.

        public static int RemoveDuplicateArray(int[] nums)
        {
            if(nums.Length == 0) return 0;

            int slow = 1;

            for (int fast = 1; fast < nums.Length; fast++)
            {
                if (nums[fast] != nums[slow])
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }

            return slow;

        }
    }
}
