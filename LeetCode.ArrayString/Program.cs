using LeetCode.ArrayString;

public class Program
{
	private static void Main(string[] args)
	{
		int[] nums = { 9 };

		int[] array = IntroductionArray.PlusOne(nums);
		foreach (int i in array) Console.WriteLine(i);
	}
}