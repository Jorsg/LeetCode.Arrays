using LeetCode.String;
using System;

internal class Program
{
	private static void Main(string[] args)
	{
		long intialMemory = GC.GetTotalMemory(true);

		var s = "aabccccaaa";
		char[] s1 = { 'h', 'e', 'l', 'l', 'o' };
		char[] str = new char[1000];
		string s2 = "Mr Jhon Smith";
		string sentence = "Tact Coa";
		string ss1 = "pale";
		string ss2 = "ple";
		int trueLength = s2.Length;
		for (int i = 0; i < s2.Length; i++)
		{
			str[i] = s2[i];
		}
		//Console.WriteLine(ScoreofStringLeetCode.ScoreOfString(s));
		//Console.WriteLine(PermutationDifferenceTwoStrings.FindPermutationDifference("abc", "bac"));
		//Console.WriteLine(Urlify.ReplaceSpaces(str, trueLength));
		//Console.WriteLine(PalindromePermutation.IsPermutationOfPalindrome(sentence));
		//Console.WriteLine(StringCompression.Compressed(s));
		char[] result = ReverseString344LeetCode.ReverseString(s1);
		foreach (var item in result)
		{
			Console.WriteLine(string.Join(" ", item));
		}
		long finalMemory = GC.GetTotalMemory(true);
		long memoryUsed = MemoryUsed(intialMemory, finalMemory);
		Console.WriteLine($"Memory: {ToSize(memoryUsed)}");

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