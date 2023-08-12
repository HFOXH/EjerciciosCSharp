using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class ContarPalabras
    {
        public static int ContarCaracter(string texto)
        {
            int contador=0;
            foreach (var item in texto)
            {
                contador += 1;
            }
            return contador;
        }
        public static int ContarLetra(string texto)
        {
            int contador = 0;
            foreach (var letra in texto)
            {
                if(char.IsLetter(letra))
                    contador += 1;
            }
            return contador;
        }
        public static int ContarPalabra(string texto)
        {
            int contador=0;
            string[] palabras = texto.Split(' ');

            foreach (var palabra in palabras)
            {
                contador += 1;
            }
            return contador;
        }
    }
}
