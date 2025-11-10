using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class PrintUnorderdPairsExercise
    {

        /// <summary>  
        /// Complexity Analysis algorithm to print all unordered pairs in an array. 
        /// O(N'2)
        PrintUnorderdPairsExercise(int[] array)
        {
            for (int i = 0; i < array.Length -1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    Console.WriteLine($"({array[i]}, {array[j]})");
                }
            }

        }
    }
}
