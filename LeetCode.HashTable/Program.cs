using LeetCode.HashTable;

public class Program
{
	private static void Main(string[] args)
	{
		//Console.WriteLine("Hello, World!");
		int[] nums = { 1, 2, 2, 4 };
		int[] nums2 = { 2, 2 };
		string keyboard = "abcdefghijklmnopqrstuvwxyz";
		string word = "cba";
		string s = "bbbbb";
		//bool result = ContainsDuplicate.ContainsDuplicateExcer(nums);
		//int result = SingleNumber.SingleNumberExcer(nums);
		//int[] result = SetMismatch.FindErrorNums(nums);
		//foreach (var item in result) Console.WriteLine(item);        
		//Console.WriteLine(Single_Row_Keyboard.CalculateTime(keyboard, word));
		Console.WriteLine(LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s));
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