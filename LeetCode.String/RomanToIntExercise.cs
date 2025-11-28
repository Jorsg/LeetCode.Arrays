using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    public class RomanToIntExercise
    {
        public static readonly Dictionary<char, int> romanNumeral = new Dictionary<char, int>
        {
          {'I', 1},
          {'V', 5},
          {'X', 10},
          {'L', 50},
          {'C', 100},
          {'D', 500},
          {'M', 1000},
        };
            
        public static int RomanToInt(string s)
        {
            int result = 0;
            int previousValue = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int value = romanNumeral[s[i]];
                if (value < previousValue)
                {
                    result -= value;
                }
                else
                {
                    result += value;
                }
                previousValue = value;
            }
            return result;
        }
    }
}
