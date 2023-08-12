using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class GenerarNumerosPrimos
    {
        public static List<int> GenerarPrimos(int n)
        {
            List<int> primos = new List<int>();
            int numero = 2;

            while (primos.Count < n)
            {
                if (EsPrimo(numero))
                {
                    primos.Add(numero);
                }
                numero++;
            }
            return primos;
        }
        public static bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
