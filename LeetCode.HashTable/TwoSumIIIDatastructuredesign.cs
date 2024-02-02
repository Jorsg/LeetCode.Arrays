using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	internal class TwoSumIIIDatastructuredesign
	{
		public List<int> nums;
		public TwoSumIIIDatastructuredesign()
		{
			nums = new List<int>();
		}

		public void Add(int number)
		{
			nums.Add(number);
		}

		public bool Find(int value)
		{
			int l = 0;
			int r = nums.Count() -1;
			nums.Sort();
			while (l < r)
			{
				int target = nums[l] + nums[r];
				if (target == value)
					return true;
				else if (target > value)
					r--;
				else
					l++;
			}
			return false;
		}
	}
}
