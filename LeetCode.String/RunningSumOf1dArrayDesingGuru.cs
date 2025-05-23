using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    /// <summary>   
    /// Grokking Data Strcuture & Algorithms for Coding Interviews
    /// Running Sum of 1d Array 
    /// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
    /// The running sum of an array is a new array that is formed by adding each element of the original array to the sum of all previous elements.
    /// Time Complexity: O(n) where n is the length of the array.
    public static class RunningSumOf1dArrayDesingGuru
    {
        public static int[] RunningSum(int[] nums)
        {
            int[] sum = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                sum[i] = nums[i] + (i == 0 ? 0 : sum[i - 1]);
            }
            return sum;
        }
    }
}
