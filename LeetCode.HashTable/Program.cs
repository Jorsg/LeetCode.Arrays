﻿using LeetCode.HashTable;

public class Program
{
	private static void Main(string[] args)
	{
		//Console.WriteLine("Hello, World!");
		int[] nums = { 2,2,1,1,1,2,2 };
		int[] nums2 = { 2, 2 };
		string keyboard = "abcdefghijklmnopqrstuvwxyz";
		string word = "cba";
		string s = "loveleetcode";
		//bool result = ContainsDuplicate.ContainsDuplicateExcer(nums);
		//int result = SingleNumber.SingleNumberExcer(nums);
		int[] result = IntersectionTwoArrays.Intersect(nums, nums2);
		foreach (var item in result) Console.WriteLine(item);        
		//Console.WriteLine(Single_Row_Keyboard.CalculateTime(keyboard, word));
		//Console.WriteLine(FirstUniqueCharacterString.MajorityElement(nums));
    }
}