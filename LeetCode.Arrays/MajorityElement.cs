using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class MajorityElement
    {
        public static int MajorityElementExercise(int[] nums)
        {
            // 1. Inicializar las dos variables (candidato y contador).
            int candidate = nums[0];
            int cont = 1;

            // 2. Bucle for para iterar por todo el array.
            for (int i = 1; i < nums.Length; i++)
            {
                // 3. Lógica de Boyer-Moore (los 4 pasos de votación/oposición).
                if (cont == 0)
                {
                    candidate = nums[i];
                    cont++;
                }
                else if (nums[i] == candidate)
                {
                    cont++;
                }
                else
                {
                    cont--;
                }
            }

            // 4. Retornar el resultado.

            return candidate; // Debe devolver el candidato que quedó.
        }
    }
}
