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
		string[] words = { "an", "apple" };
		string[] words2 = { "abcddefg" };
		char x = 'a';
		string s = "a";
		//Console.WriteLine(FindWordsContainingCharacter.FindWordsContaining(words, x));
		int result = 3 + 1 * 5 / 2;
		//Console.WriteLine(TwoStringArraysEquivalent.ArrayStringsAreEqual(words, words2));
		Console.WriteLine(CheckStringAcronymWords.IsAcronym(words,s));	
		
	}
}