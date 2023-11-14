using LeetCode.Microsoft;

public class Program
{
	private static void Main(string[] args)
	{
		//Console.WriteLine("Hello, World!");
		string s = "codeleet";
		int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
		//int result = ExcersiceEasy.Sum(-10, 4);
		
		Console.WriteLine(ExcersiceEasy.RestoreString(s, indices));
	}
}