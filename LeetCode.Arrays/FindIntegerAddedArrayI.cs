using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    static class FindIntegerAddedArrayI
    {
        public static int AddInteger(int[] nums1, int[] nums2)
        {
			int result = 0;
			for (int i = 0; i < nums2.Length; i++)
			{
				result += nums2[i] - nums1[i];
			}
			return result / nums1.Length;
		}
    }
}
