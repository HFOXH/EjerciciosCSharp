using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class NumeroArmstrong
    {
        public static bool EsNumeroArmstrong(int numero)
        {
            string numConvertido = numero.ToString();
            int cantCaracteres = numConvertido.Length;
            int[] arrayDeDigitos = new int[cantCaracteres];
            int[] resultado = new int[cantCaracteres];
            int r=0;
            for (int i = 0; i < cantCaracteres; i++) {
                arrayDeDigitos[i] = int.Parse(numConvertido[i].ToString());
                resultado[i] = (int)Math.Pow(arrayDeDigitos[i], cantCaracteres);
            }
            foreach (int a in resultado) {
                r += a;
            }
            Console.WriteLine(r);
            if (r == numero) { return true; } else { return false; }
        }
    }
}
