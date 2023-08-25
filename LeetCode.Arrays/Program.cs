using LeetCode.Arrays;

public class Program
{
	private static void Main(string[] args)
	{
		DVD[] dvdCollection = new DVD[3];

		dvdCollection[0] = new DVD("Pelicula 1", 2000, "Director 1");
		dvdCollection[1] = new DVD("Pelicula 2", 2010, "Director 2");
		dvdCollection[2] = new DVD("Pelicula 3", 2020, "Director 3");


		foreach (var dvd in dvdCollection) Console.WriteLine(dvd.toStrinPrint());
			
	}
}