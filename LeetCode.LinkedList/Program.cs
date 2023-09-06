using LeetCode.LinkedList;

public class Program
{
	private static void Main(string[] args)
	{
		MyLinkedList myLinkedList = new MyLinkedList();
		//myLinkedList.AddAtHead(1);
		//myLinkedList.AddAtTail(3);
		//myLinkedList.AddAtIndex(1, 2);
		Console.WriteLine(myLinkedList.Get(1));
		//myLinkedList.DeleteAtIndex(1);
		myLinkedList.Get(1);
	}
}