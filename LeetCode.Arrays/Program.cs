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
		int[] arr1 = { 2, 6, 4 };
		int[] arr2 = { 9, 7, 5 };
		int m = 3, n = 3;
		int[] nums = { 3, 6, 9 };
		int k = 4;
		int val = 3;
		int[][] nums1 = { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };
		string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
		IList<IList<string>> items = new List<IList<string>>
		{
			new List<string> { "phone", "blue", "pixel" },
			new List<string> { "computer", "silver", "phone" },
			new List<string> { "phone", "gold", "iphone" }
		};
		string ruleKey = "type";
		string ruleValue = "phone";
		string[] operation = { "--X", "X++", "X++" };

		string command = "G()(al)";
		string s = "Hello how are you Contestant";
		//int[][] grid = { new int[] { 9, 9, 8, 1 }, new int[] { 5, 6, 2, 6 }, new int[] { 8, 2, 6, 4 }, new int[] { 6, 2, 2, 2 }};
		int[][] grid = { new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 1, 2, 1, 1 }, new int[] {1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1 } };
		//ArrayInsertions.Merge(arr1, m, arr2, n);
		//Console.WriteLine(ArrayDelete.RemoveElement(nums, val));
		//Console.WriteLine(ArrayDelete.RemoveDuplicatesII(nums));
		//Console.WriteLine(SearchArray.CheckIfExist(nums));
		//Console.WriteLine(SearchArray.validMountainArray(nums));
		//int[] squared = InPlaceArray.ReplaceElements(nums);
		//foreach (int i in squared)	Console.WriteLine(i);
		//Console.WriteLine(InPlaceArray.removeDuplicates(nums));
		//int[] result = InPlaceArray.MoveZeros(nums);
		//foreach(int i in result)Console.WriteLine(i);
		//int[] result = InPlaceArray.SortArrayByParity(nums);
		//foreach (int i in result) Console.WriteLine(i);
		//Console.WriteLine(ArrayExcersices.FindMaxConsecutiveOnes(nums));
		//Console.WriteLine(ArrayExcersices.ThirdMax(nums));
		//IList<int> list = ArrayExcersices.FindDisappearedNumbers(nums);
		//int[] result = ArrayExcersices.BuildArray(nums);
		//int[] result = ArrayExcersices.GetConcatenation(nums);
		// int[] result = ArrayExcersices.Shuffle(nums, n);
		//int result = ArrayPracticExcersice.MostWordsFound(sentences);
		//IList<bool> result = ArrayPracticExcersice.KidsWithCandies(nums, val);
		//int[] result = ArrayPracticExcersice.LeftRightDifference(nums);
		//foreach (var i in result) Console.WriteLine(i);
		//Console.WriteLine(ArrayPracticExcersice.CanBeIncreasing(nums));
		//Console.WriteLine(ArrayPracticExercise.SumIndicesWithKSetBits(nums, k));
		//int[] result = ArrayExercise3.DecompressRLElist(nums);
		//int result = ArrayExercise3.CountMatches(items, ruleKey, ruleValue);
		//Console.WriteLine(ArrayExercise3.Interpret(command));
		//string result = TruncateSentence.TruncateSentenceExce(s,k);
		//Console.WriteLine(FindIntegerAddedArrayI.AddInteger(arr1, arr2));
		//Console.WriteLine(FindMinimumOperationsMakeAllElementsDivisibleThree.MinimumOperations(nums));
		//Console.WriteLine(Factorial(5));
		int[][] result = LargestLocalValuesMatrix.LargestLocal(grid);
		PrintMatrix(result);

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

	private static int Factorial(int n)
	{
		int result = 1;
		if (n == 0) return 1;
		for (int i = 1; i <= n; i++)
		{
			result *= i;
		}
		return result;

		//while (n > 0)
		//{
		//	result *= n;
		//	n--;
		//}
		//return result;
	}

	private static void PrintMatrix(int[][] matrix)
	{
		for (int i = 0; i < matrix.Length; i++)
		{
			for (int j = 0; j < matrix[i].Length; j++)
			{
				Console.Write(matrix[i][j] + " ");
			}
			Console.WriteLine();
		}
	}

}