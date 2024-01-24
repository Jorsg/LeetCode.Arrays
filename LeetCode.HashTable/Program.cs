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
		string s = "loveleetcode";
		//bool result = ContainsDuplicate.ContainsDuplicateExcer(nums);
		//int result = SingleNumber.SingleNumberExcer(nums);
		int[] result = SetMismatch.FindErrorNums(nums);
		foreach (var item in result) Console.WriteLine(item);        
		//Console.WriteLine(Single_Row_Keyboard.CalculateTime(keyboard, word));
		//Console.WriteLine(FirstUniqueCharacterString.MajorityElement(nums));
    }
}