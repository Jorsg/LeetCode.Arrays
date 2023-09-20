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
		list.val = 0;
		list.val = 1;
		//list.val = 3;
		//list.val = 4;
		//list.val = 5;
		//list.val = 6;
		//listCycle.RemoveNthFromEnd(list, 2);
		//ReverseLinkedList list1 = new ReverseLinkedList();
		//list1.RemoveElements(list, 6);
		//Console.WriteLine(list1.ReverseList(list));
		ExcersicesLinkedList excersices = new ExcersicesLinkedList();
		Console.WriteLine(excersices.GetDecimalValue(list));
		
		

	}
}