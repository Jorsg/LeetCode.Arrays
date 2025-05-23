﻿using LeetCode.LinkedList;

public class Program
{
	private static void Main(string[] args)
	{
		long intialMemory = GC.GetTotalMemory(true);
		MyLinkedList myLinkedList = new MyLinkedList();
		//myLinkedList.AddAtHead(1);
		//myLinkedList.AddAtTail(3);
		//myLinkedList.AddAtIndex(1, 2);
		//Console.WriteLine(myLinkedList.Get(1));
		//myLinkedList.DeleteAtIndex(1);
		//myLinkedList.Get(1);
		//LinkedListCycle listCycle = new LinkedListCycle();
		ListNode list = new ListNode();
		list.val = 97;
		list.val = 110;
		list.val = 97;
		//list.val = 3;
		//list.val = 4;
		//list.val = 5;
		//list.val = 6;
		//listCycle.RemoveNthFromEnd(list, 2);
		//ReverseLinkedList list1 = new ReverseLinkedList();
		//var result = list1.DeleteDuplicatesSortList(list);
		//foreach (var item in result) Console.WriteLine();
		//Console.WriteLine(list1.DeleteDuplicatesSortList(list));
		//ExcersicesLinkedList excersices = new ExcersicesLinkedList();
		//Console.WriteLine(excersices.GetDecimalValue(list));
		PalindromeLinkedList.IsPalindrome(list);
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