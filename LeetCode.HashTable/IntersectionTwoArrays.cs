using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	public static class IntersectionTwoArrays
	{
		public static int[] Intersection(int[] nums1, int[] nums2)
		{
			var setOne = new HashSet<int>(nums1);
			var setTwo = new HashSet<int>(nums2);
			var result = new List<int>();

            foreach (var item in setOne)
            {
                if(setTwo.Contains(item))
					result.Add(item);
            }

			return result.ToArray();
        }
	}
}
