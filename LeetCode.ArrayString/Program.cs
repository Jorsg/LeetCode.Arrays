using LeetCode.ArrayString;

public class Program
{
	private static void Main(string[] args)
	{
		int[] nums = { 9 };

		//int[] array = IntroductionArray.PlusOne(nums);
		//foreach (int i in array) Console.WriteLine(i);
		//string a = "11", b = "1";
		//Console.WriteLine(AddBinary.AddBinaryExercesi(a,b));
		string allowed = "ab";
		string[] words = { "ad", "bd", "aaab", "baa", "badab" };
		string[] words2 = { "abcddefg" };
		char x = 'a';
		string s = "(1+(2*3)+((8)/4))+1";
		int num = 8;
		string key = "the quick brown fox jumps over the lazy dog", message = "vkbs bs t suepuv";

		//Console.WriteLine(FindWordsContainingCharacter.FindWordsContaining(words, x));
		int result = 3 + 1 * 5 / 2;
		//Console.WriteLine(TwoStringArraysEquivalent.ArrayStringsAreEqual(words, words2));
		
       // Console.WriteLine(.MaxDepth(s));	
		
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