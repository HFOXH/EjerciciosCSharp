using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Factorial
    {
        public static int CalcularFactorial(int numero)
        {
            int resultado = 1;
            if (numero == 0)
                resultado = 1;
            for (int i = numero; i > 1; i--)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
