using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class PlusOneExercise
    {
        //Plus One: Dado un número grande representado como un array de dígitos, súmale uno al entero.
        public static int[] PlusOne(int[] nums) 
        {
            int[] result = new int[nums.Length + 1];
            for(int i = nums.Length - 1; i >=0;i--)
            {
                if (nums[i] < 9)
                {
                    nums[i]++;
                    return nums;
                }
                nums[i] = 0;
            }

            result[0] = 1;
            return result;
        }
    }
}
