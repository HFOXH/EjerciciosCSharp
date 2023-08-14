using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class GenerarSecuenciaFibonacci
    {
        public static void Fibonacci(int n)
        {
            int valorPre = 0, valorPos = 1;

            for (int i = 0; i < n; i++)
            {
                int valorOriginal = valorPre;
                valorPre = valorPos;
                valorPos = valorOriginal + valorPre;
                Console.WriteLine(valorPre);
            }
        }
    }
}
