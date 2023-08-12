using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class ConvertirRomanoAArabe
    {
        public static int ConvertirRomanoArabe(string numeroRomano)
        {
            int resultado = 0;
            int cantDigitos = numeroRomano.Length;
            int[] arrayDeDigitos = new int[cantDigitos];
            for (int i = 0; i < cantDigitos; i++)
            {
                char letra = numeroRomano[i];

                // Asigna valor a cada dígito en el array
                if (letra == 'I') { arrayDeDigitos[i] = 1; }
                else if (letra == 'V') { arrayDeDigitos[i] = 5; }
                else if (letra == 'X') { arrayDeDigitos[i] = 10; }
                else if (letra == 'L') { arrayDeDigitos[i] = 50; }
                else if (letra == 'C') { arrayDeDigitos[i] = 100; }
                else if (letra == 'D') { arrayDeDigitos[i] = 500; }
                else if (letra == 'M') { arrayDeDigitos[i] = 1000; }
            }
            //calcula el valor
            for (int i = 0; i < cantDigitos -1; i++)
            {
                if (arrayDeDigitos[i] >= arrayDeDigitos[i + 1])
                {
                    resultado += arrayDeDigitos[i];
                }
                else {
                    resultado -= arrayDeDigitos[i];
                }
            }
            resultado += arrayDeDigitos[cantDigitos - 1];
            return resultado;
        }
    }
}
