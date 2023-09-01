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

		//int[] nums = { -4, -1, 0, 3, 10 };

		//Console.WriteLine(Arrays.FindMaxConsecutiveOnes(nums));
		//Console.WriteLine(Arrays.FindNumbers(nums));
		//int[] newMatrix = Arrays.SortedSquares(nums);
		//foreach (var matrix in newMatrix) Console.WriteLine(matrix);
		//ArrayInsertions.InserEndArray();
		//ArrayInsertions.InsertSrtarArray();
		int[] arr1 = { 1, 2, 3, 0, 0, 0 };
		int[] arr2 = { 2, 5, 6 };
		int m = 3, n = 3;
		int[] nums = { 3, 1, 2, 4 };
		int val = 3;
		//ArrayInsertions.Merge(arr1, m, arr2, n);
		//Console.WriteLine(ArrayDelete.RemoveElement(nums, val));
		//Console.WriteLine(ArrayDelete.RemoveDuplicates(nums));
		//Console.WriteLine(SearchArray.CheckIfExist(nums));
		//Console.WriteLine(SearchArray.ValidMountainArray(nums));
		//int[] squared = InPlaceArray.ReplaceElements(nums);
		//foreach (int i in squared)	Console.WriteLine(i);
		//Console.WriteLine(InPlaceArray.removeDuplicates(nums));
		//int[] result = InPlaceArray.MoveZeros(nums);
		//foreach(int i in result)Console.WriteLine(i);
		int[] result = InPlaceArray.SortArrayByParity(nums);
		foreach (int i in result) Console.WriteLine(i);




	}

}