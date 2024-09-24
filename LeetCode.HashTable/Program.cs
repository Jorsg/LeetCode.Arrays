using LeetCode.HashTable;

public class Program
{
	private static void Main(string[] args)
	{
		//Console.WriteLine("Hello, World!");
		int[] nums1 = { 2,3,2};
		int[] nums2 = { 1, 2 };
		string keyboard = "abcdefghijklmnopqrstuvwxyz";
		string word = "cba";
		string s = "rat";
		string t = "cat";
		//bool result = ContainsDuplicate.ContainsDuplicateExcer(nums);
		//int result = SingleNumber.SingleNumberExcer(nums);
		//int[] result = SetMismatch.FindErrorNums(nums);
		//foreach (var item in result) Console.WriteLine(item);        
		//Console.WriteLine(Single_Row_Keyboard.CalculateTime(keyboard, word));
		//Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s));
		//Console.WriteLine(FindNumberGoodPairsI.NumberOfPairs(nums, nums2, 2));
		//int[] result = FindCommonElementsBetweenTwoArrays.FindIntersectionValues(nums1, nums2);
		//foreach (var item in result) Console.WriteLine(item);
		Console.WriteLine(ValidAnagram.IsAnagram(s,t));

	}

	private static long MemoryUsed(long intialMemory, long finalMemory)
	{
		return finalMemory - intialMemory;
	}

	private static string ToSize(long size)
	{
		string[] sizes = { "B", "KB", "MB", "GB" };
		double len = size;
		int order = 0;
		while (len >= 1024 && order + 1 < sizes.Length)
		{
			order++;
			len = len / 1024;
		}
		return $"{len:0.##} {sizes[order]}";
	}
}