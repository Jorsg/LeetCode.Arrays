using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
	public class CalPromdVarDesEFOV
	{
		public static void CalPromdVarDesv(int[] dato)
		{
			//55. Prof. Efraín Oviedo Book.
			//Calcular el promedio, varianza y desviación estándar de un conjunto de datos.
			//Ejemplo: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] => Promedio: 5.5, Varianza: 9.166666666666666, Desviación Estándar: 3.0276503540974917
			int sum = 0, sum2 = 0, n = 0, promd = 0, varianza = 0, desv = 0;

			while (0 != dato[n])
			{
				sum += dato[n];
				n++;
			}
			promd = sum / n;
			for (int i = 0; i < n; i++)
			{
				sum2 = sum2 + (int)Math.Pow(dato[i] - promd, 2);
			}
			varianza = sum2 / (n - 1);
			desv = (int)Math.Sqrt(varianza);
			Console.WriteLine($"Promedio: {promd}, Varianza: {varianza}, Desviación Estándar: {desv}");
		}
	}
}
