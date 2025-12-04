using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ArrayString
{
	public class LongestCommonPrefix
	{
		public string LongestCommonPrefix_Excercise(string[] strs)
		{
			//Runtime: 98 ms
			// Memory: 40.37 MB
			if (strs.Length == 0) return "";

			String prefix = strs[0];
			for (int i = 1; i < strs.Length; i++)
			{
				while (strs[i].IndexOf(prefix) != 0)
				{
					prefix = prefix.Substring(0, prefix.Length - 1);
					if (prefix == "") return "";

			    }
			}

			return prefix;
		}

		//New version
        public string LongestCommonPrefix_V2(string[] strs)
        {
            if (strs == null || strs.Length == 0) return string.Empty;
            for (int i = 0; i < strs[0].Length; i++)
            {
                char currentChar = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != currentChar)
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }
    }

	
}
