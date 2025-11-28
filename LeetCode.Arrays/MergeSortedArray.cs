using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class MergeSortedArray
    {
        //Merge Sorted Array
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1; // Pointer for nums1
            int p2 = n - 1;
            int write_idx = m + n - 1;
            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] >= nums2[p2])
                {
                    nums1[write_idx] = nums1[p1];
                    p1--;

                }
                else
                {
                    nums1[write_idx] = nums2[p2];
                    p2--;
                }
                write_idx--;

            }
            while (p2 >= 0)
            {
                nums1[write_idx] = nums2[p2];
                p2--;
                write_idx--;
            }
        }
    }
}
