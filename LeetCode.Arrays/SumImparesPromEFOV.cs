using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public class SumImparesPromEFOV
	{
		//54. Prof. Efraín Oviedo Book.
		//Suma de los elementos impares y promedio
		//Dado un array de enteros, devolver la suma de los elementos impares y el promedio de los mismos.
		//Ejemplo: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] => Suma de los impares: 25 y el Promedio: 5
		public static void SumImparPromed(int[] array)
		{
			int k =0;	
			int sum = 0; int numImpares = 0; int promdio = 0;
			
			while(k <= array.Length)
			{
				sum += array[k];
				numImpares++;
				k += 2;
			}
			promdio = sum / numImpares;
			Console.WriteLine($"Suma de los impares: {sum} y el Promedio: {promdio}");
		}
	}
}
