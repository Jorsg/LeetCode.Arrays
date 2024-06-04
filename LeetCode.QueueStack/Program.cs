internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
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