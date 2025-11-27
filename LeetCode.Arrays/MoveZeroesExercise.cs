using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    //Move Zeroes: Dado un array, mueve todos los 0 al final manteniendo el orden relativo de los elementos no cero
    public class MoveZeroesExercise
    {
        public static void MoveZeroes(int[] nums)
        {
            int write_idx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] !=0)
                {
                    nums[write_idx] = nums[i];
                    write_idx++;
                }
            }
            for(int j= write_idx; j< nums.Length; j++)
            {
                nums[j] = 0;
            }
        }
    }
}
