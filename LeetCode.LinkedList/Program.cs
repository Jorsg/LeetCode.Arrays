using LeetCode.LinkedList;

public class Program
{
	private static void Main(string[] args)
	{
		MyLinkedList myLinkedList = new MyLinkedList();
		//myLinkedList.AddAtHead(1);
		//myLinkedList.AddAtTail(3);
		//myLinkedList.AddAtIndex(1, 2);
		//Console.WriteLine(myLinkedList.Get(1));
		//myLinkedList.DeleteAtIndex(1);
		//myLinkedList.Get(1);
		LinkedListCycle listCycle = new LinkedListCycle();
		ListNode list = new ListNode();
		list.val = 1;
		list.val = 1;
		list.val = 2;
		//list.val = 3;
		//list.val = 4;
		//list.val = 5;
		//list.val = 6;
		//listCycle.RemoveNthFromEnd(list, 2);
		ReverseLinkedList list1 = new ReverseLinkedList();
		var result = list1.DeleteDuplicatesSortList(list);
		//foreach (var item in result) Console.WriteLine();
		//Console.WriteLine(list1.DeleteDuplicatesSortList(list));
		//ExcersicesLinkedList excersices = new ExcersicesLinkedList();
		//Console.WriteLine(excersices.GetDecimalValue(list));
		
		

	}
}