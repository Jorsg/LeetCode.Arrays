using LeetCode.Arrays;

public class Program
{
	private static void Main(string[] args)
	{
		DVD[] dvdCollection = new DVD[3];

		dvdCollection[0] = new DVD("Pelicula 1", 2000, "Director 1");
		dvdCollection[1] = new DVD("Pelicula 2", 2010, "Director 2");
		dvdCollection[2] = new DVD("Pelicula 3", 2020, "Director 3");


		//foreach (var dvd in dvdCollection) Console.WriteLine(dvd.toStrinPrint());

		int[] nums = { 123, 1222, 0, 13, 123, 122222 };
		Console.WriteLine(FindNumbers(nums));



	}

	//Given a binary array nums, return the maximum number of consecutive 1's in the array.
	public static int FindMaxConsecutiveOnes(int[] nums)
	{
		int maxCount = 0;
		int count = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 1)
				count++;
			else
			{
				maxCount = Math.Max(maxCount, count);
				count = 0;
			}
		}
		return Math.Max(maxCount, count);
	}

	//Find Numbers with Even Number of Digits
	//Given an array nums of integers, return how many of them contain an even number of digits.
	public static int FindNumbers(int[] nums)
	{
		int count = 0;
		for (int i = 0; i < nums.Length; i++)
		{

			if ((nums[i].ToString().Length % 2) == 0)
				count++;
		}
		return count;
	}
}