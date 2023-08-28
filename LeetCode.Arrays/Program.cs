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
		//ArrayInsertions.Merge(arr1, m, arr2, n);
		ArrayDelete.DeletinAnyWhereArray();




	}

}