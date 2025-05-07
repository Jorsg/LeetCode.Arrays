using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    public class Generic_Algorithms
    {
        //Make a function that show the integers numbers 1 to n and their cuadratic sum
        public static void Cuadratic_Sum(int number)
        {
            for (int i = 1; i < number; i++)
            {
                int sum = 0, odd = 1;
                for (int j = 1; j <= i; j++)
                {
                    sum += odd;
                    odd += 2;
                }
                Console.WriteLine($"Cuadratic sum of {i} is {sum}");
            }
        }
    }
}
